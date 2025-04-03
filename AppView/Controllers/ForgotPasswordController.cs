using AppView.Models.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;

namespace AppView.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private readonly HotelDbContext _context;
        private readonly IEmailService _emailService; // Thêm EmailService

        public ForgotPasswordController(HotelDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService; // Khởi tạo dịch vụ gửi email
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        // Xử lý yêu cầu quên mật khẩu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var taiKhoann = await _context.TaiKhoans.FirstOrDefaultAsync(t => t.Email == email);
            if (taiKhoann == null)
            {
                ModelState.AddModelError("", "Email không tồn tại.");
                return View();
            }

            // Gửi thông tin tài khoản qua email
            string emailBody = $"<h1>Thông tin tài khoản của bạn</h1>" +
            $"<p>Kính gửi {taiKhoann.TaiKhoan},</p>" +
            $"<p>Cảm ơn bạn đã đăng ký tài khoản tại ROYAL.</p>" +
            $"<p>Tên tài khoản: {taiKhoann.TaiKhoan}</p>" +
            $"<p>Mật khẩu: {taiKhoann.MatKhau}</p>" +
            $"<p>Chúng tôi khuyên bạn nên thay đổi mật khẩu của mình ngay lập tức để đảm bảo an toàn.</p>" +
            $"<p>Trân trọng!</p>";

            // Gửi email chứa thông tin tài khoản và mật khẩu
            await _emailService.SendBookingConfirmation(taiKhoann.Email, emailBody);

            ViewData["Message"] = "Thông tin tài khoản đã được gửi đến email của bạn.";
            return View();
        }

       
    }
}
