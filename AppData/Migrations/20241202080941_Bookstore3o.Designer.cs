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
    [Migration("20241202080941_Bookstore3o")]
    partial class Bookstore3o
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

                    b.Property<int?>("LoaiPhongMaLoaiPhong")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("LoaiPhongMaLoaiPhong");

                    b.ToTable("AnhChiTiets");
                });

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CCCD")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IDPhongChiTiet")
                        .HasColumnType("int");

                    b.Property<string>("KhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PhongChiTietID")
                        .HasColumnType("int");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongPhong")
                        .HasColumnType("int");

                    b.Property<int>("SoNguoiLon")
                        .HasColumnType("int");

                    b.Property<int>("SoTreEm")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PhongChiTietID");

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

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaLoaiPhong");

                    b.ToTable("LoaiPhongs");
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

            modelBuilder.Entity("AppData.PhongChiTiet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("LoaiPhongMaLoaiPhong")
                        .HasColumnType("int");

                    b.Property<int>("SoNguoi")
                        .HasColumnType("int");

                    b.Property<string>("TenPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("LoaiPhongMaLoaiPhong");

                    b.ToTable("PhongChiTiets");
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

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungChiTiet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDungNgan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTinTuc")
                        .IsRequired()
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

            modelBuilder.Entity("DichVuLoaiPhong", b =>
                {
                    b.Property<int>("DichVusID")
                        .HasColumnType("int");

                    b.Property<int>("LoaiPhongsMaLoaiPhong")
                        .HasColumnType("int");

                    b.HasKey("DichVusID", "LoaiPhongsMaLoaiPhong");

                    b.HasIndex("LoaiPhongsMaLoaiPhong");

                    b.ToTable("LoaiPhongDichVu", (string)null);
                });

            modelBuilder.Entity("AppData.AnhChiTiet", b =>
                {
                    b.HasOne("AppData.LoaiPhong", null)
                        .WithMany("HinhAnhPhongs")
                        .HasForeignKey("LoaiPhongMaLoaiPhong");
                });

            modelBuilder.Entity("AppData.DatPhong", b =>
                {
                    b.HasOne("AppData.PhongChiTiet", "PhongChiTiet")
                        .WithMany()
                        .HasForeignKey("PhongChiTietID");

                    b.Navigation("PhongChiTiet");
                });

            modelBuilder.Entity("AppData.PhongChiTiet", b =>
                {
                    b.HasOne("AppData.LoaiPhong", "LoaiPhong")
                        .WithMany("phongs")
                        .HasForeignKey("LoaiPhongMaLoaiPhong");

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("DichVuLoaiPhong", b =>
                {
                    b.HasOne("AppData.DichVu", null)
                        .WithMany()
                        .HasForeignKey("DichVusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.LoaiPhong", null)
                        .WithMany()
                        .HasForeignKey("LoaiPhongsMaLoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.LoaiPhong", b =>
                {
                    b.Navigation("HinhAnhPhongs");

                    b.Navigation("phongs");
                });
#pragma warning restore 612, 618
        }
    }
}
