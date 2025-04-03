using AppData;
using AppView.Models.Service;
using AppView.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace AppView.Controllers
{
    public class SignupController : Controller
    {
        private readonly HotelDbContext _context;
        private readonly IEmailService _emailService; // Thêm EmailService

        public SignupController(HotelDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService; // Khởi tạo dịch vụ gửi email
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup([Bind("Email,TaiKhoan,MatKhau")] TaiKhoann taiKhoann)
        {
            if (ModelState.IsValid)
            {
                var existingEmail = await _context.TaiKhoans.FirstOrDefaultAsync(t => t.Email == taiKhoann.Email);
                if (existingEmail != null)
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại. Vui lòng sử dụng email khác!");
                    return View(taiKhoann);
                }

                var existingAccount = await _context.TaiKhoans.FirstOrDefaultAsync(t => t.TaiKhoan == taiKhoann.TaiKhoan);
                if (existingAccount != null)
                {
                    ModelState.AddModelError("TaiKhoan", "Tài khoản không hợp lệ. Vui lòng nhập lại!");
                    return View(taiKhoann);
                }

                // Tạo mã xác nhận ngẫu nhiên
                var maXacNhan = new Random().Next(100000, 999999).ToString();
                taiKhoann.MaXacNhan = maXacNhan;

                // Gửi email chứa mã xác nhận
                await _emailService.SendBookingConfirmation(taiKhoann.Email, maXacNhan);

                // Lưu thông tin tài khoản tạm thời trong session
                HttpContext.Session.SetString("TaiKhoanSignup", JsonConvert.SerializeObject(taiKhoann));

                // Chuyển hướng đến trang xác nhận
                return RedirectToAction("XacNhan");
            }
            return View(taiKhoann);
        }
        public IActionResult XacNhan()
        {
            return View();
        }

        // Xác nhận mã
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> XacNhan(string maXacNhan)
        {
            var taiKhoannJson = HttpContext.Session.GetString("TaiKhoanSignup");
            if (taiKhoannJson == null)
            {
                return NotFound();
            }

            var taiKhoann = JsonConvert.DeserializeObject<TaiKhoann>(taiKhoannJson);

            if (taiKhoann.MaXacNhan == maXacNhan)
            {
                // Nếu mã xác nhận đúng, lưu tài khoản vào CSDL
                taiKhoann.Quyen = "khachhang";
                _context.Add(taiKhoann);
                await _context.SaveChangesAsync();

                // Xóa thông tin tạm trong session
                HttpContext.Session.Remove("TaiKhoanSignup");

                return RedirectToAction("Login", "Login");
            }

            ModelState.AddModelError("MaXacNhan", "Mã xác nhận không đúng. Vui lòng thử lại!");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResendCode()
        {
            var taiKhoannJson = HttpContext.Session.GetString("TaiKhoanSignup");
            if (taiKhoannJson == null)
            {
                return NotFound();
            }

            var lastSentTimeStr = HttpContext.Session.GetString("LastSentTime");
            if (DateTime.TryParse(lastSentTimeStr, out DateTime lastSentTime))
            {
                // Kiểm tra thời gian gửi mã trước đó
                if (DateTime.UtcNow < lastSentTime.AddMinutes(1))
                {
                    // Nếu chưa đủ 1 phút, không gửi mã
                    ViewData["Message"] = "Vui lòng đợi ít nhất 1 phút trước khi gửi lại mã xác nhận.";
                    return View("XacNhan");
                }
            }

            var taiKhoann = JsonConvert.DeserializeObject<TaiKhoann>(taiKhoannJson);
            var maXacNhan = new Random().Next(100000, 999999).ToString();
            taiKhoann.MaXacNhan = maXacNhan;

            // Gửi lại mã xác nhận
            await _emailService.SendBookingConfirmation(taiKhoann.Email, maXacNhan);

            // Cập nhật mã xác nhận và thời gian gửi trong session
            HttpContext.Session.SetString("TaiKhoanSignup", JsonConvert.SerializeObject(taiKhoann));
            HttpContext.Session.SetString("LastSentTime", DateTime.UtcNow.ToString());

            // Trả về thông báo thành công
            ViewData["Message"] = "Mã xác nhận đã được gửi lại. Vui lòng kiểm tra email của bạn.";
            return View("XacNhan");
        }
       


    }
}