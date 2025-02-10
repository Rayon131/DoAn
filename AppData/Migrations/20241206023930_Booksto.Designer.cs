﻿// <auto-generated />
using System;
using AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppData.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20241206023930_Booksto")]
    partial class Booksto
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
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int?>("SoNguoiLon")
                        .HasColumnType("int");

                    b.Property<int?>("SoTreEm")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LoaiPhongID");

                    b.ToTable("DatPhongs");
                });

            modelBuilder.Entity("AppData.DichVu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoaiPhongId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("DichVus");
                });

            modelBuilder.Entity("AppData.FaceBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("faceBooks");
                });

            modelBuilder.Entity("AppData.GG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("gGs");
                });

            modelBuilder.Entity("AppData.Inter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("inters");
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

                    b.Property<string>("LogoSDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

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
                        .IsRequired()
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<string>("TenController")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("AppData.TikTok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("tikTok");
                });

            modelBuilder.Entity("AppData.TinTuc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("HinhAnh1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhAnh3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungChiTiet1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungChiTiet2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungChiTiet3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungChiTiet4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungNgan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTinTucChinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTinTucPhu")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Wel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
#pragma warning restore 612, 618
        }
    }
}
