﻿// <auto-generated />
using System;
using AppView;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppView.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20250116034731_LuanUp")]
    partial class LuanUp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppData.AnhChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Anh")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("IdLoaiPhong")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiPhong");

                    b.ToTable("AnhChiTiets");
                });

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<int?>("LoaiPhongID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SoLuongPhong")
                        .HasColumnType("int");

                    b.Property<int>("SoNguoiLon")
                        .HasColumnType("int");

                    b.Property<int>("SoTreEm")
                        .HasColumnType("int");

                    b.Property<int?>("TaiKhoannID")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("LoaiPhongID");

                    b.HasIndex("TaiKhoannID");

                    b.ToTable("DatPhongs");
                });

            modelBuilder.Entity("AppData.DichVu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoaiPhongId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("DichVus");
                });

            modelBuilder.Entity("AppData.LichDatPhong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("LoaiPhongID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngay")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuongDaDat")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LoaiPhongID");

                    b.ToTable("LichDatPhongs");
                });

            modelBuilder.Entity("AppData.LienHe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("lienHes");
                });

            modelBuilder.Entity("AppData.LoGo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("loGos");
                });

            modelBuilder.Entity("AppData.LoaiPhong", b =>
                {
                    b.Property<int>("MaLoaiPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiPhong"));

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("GiaGiamGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaGoc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Giuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoPhongCon")
                        .HasColumnType("int");

                    b.Property<string>("TenLoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<bool>("Xoa")
                        .HasColumnType("bit");

                    b.HasKey("MaLoaiPhong");

                    b.ToTable("LoaiPhongs");
                });

            modelBuilder.Entity("AppData.LoaiPhongDichVu", b =>
                {
                    b.Property<int>("DichVusID")
                        .HasColumnType("int");

                    b.Property<int>("LoaiPhongsId")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.HasKey("DichVusID", "LoaiPhongsId");

                    b.HasIndex("LoaiPhongsId");

                    b.ToTable("LoaiPhongDichVu");
                });

            modelBuilder.Entity("AppData.MenuItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<string>("TenController")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("AppData.Slide", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("AppData.TaiKhoann", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Quyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("AppData.TinTuc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("HinhAnh")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NoiDungChiTiet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungNgan")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenTinTucChinh")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("tinTucs");
                });

            modelBuilder.Entity("AppData.WelCome", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Wel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("welComes");
                });

            modelBuilder.Entity("AppData.AnhChiTiet", b =>
                {
                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany("HinhAnhPhongs")
                        .HasForeignKey("IdLoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany("DatPhongs")
                        .HasForeignKey("LoaiPhongID");

                    b.HasOne("AppData.TaiKhoann", null)
                        .WithMany("DatPhongs")
                        .HasForeignKey("TaiKhoannID");

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("AppData.LichDatPhong", b =>
                {
                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany()
                        .HasForeignKey("LoaiPhongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("AppData.LoaiPhongDichVu", b =>
                {
                    b.HasOne("AppData.DichVu", "DichVu")
                        .WithMany("DichVuLoaiPhongs")
                        .HasForeignKey("DichVusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany("DichVuLoaiPhongs")
                        .HasForeignKey("LoaiPhongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DichVu");

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("AppData.DichVu", b =>
                {
                    b.Navigation("DichVuLoaiPhongs");
                });

            modelBuilder.Entity("AppData.LoaiPhong", b =>
                {
                    b.Navigation("DatPhongs");

                    b.Navigation("DichVuLoaiPhongs");

                    b.Navigation("HinhAnhPhongs");
                });

            modelBuilder.Entity("AppData.TaiKhoann", b =>
                {
                    b.Navigation("DatPhongs");
                });
#pragma warning restore 612, 618
        }
    }
}
