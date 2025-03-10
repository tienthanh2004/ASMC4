﻿// <auto-generated />
using System;
using App_Data_ClassLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App_Data_ClassLib.Migrations
{
    [DbContext(typeof(ASMC4Context))]
    [Migration("20240326082441_16-3")]
    partial class _163
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("App_Data_ClassLib.Models.GioHang", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaSanPham")
                        .HasColumnType("float")
                        .HasColumnName("GiaSanPham");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuongSP")
                        .HasColumnType("int")
                        .HasColumnName("SoLuongSP");

                    b.HasKey("UserID");

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("IDUser");

                    b.HasIndex("IDSPCT");

                    b.ToTable("GioHangChiTiet", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IDHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("DiaChi");

                    b.Property<Guid>("IDPTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDVouncher")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDVouncher");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("Nvarchar(50)")
                        .HasColumnName("SoDienThoai");

                    b.Property<DateTime>("ThoiGianThanhToan")
                        .HasColumnType("DateTime")
                        .HasColumnName("ThoiGianThanhToan");

                    b.Property<double>("TongTien")
                        .HasColumnType("float")
                        .HasColumnName("TongTien");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDHD");

                    b.HasIndex("IDVouncher");

                    b.HasIndex("UserID");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IDHDCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaSP")
                        .HasColumnType("float")
                        .HasColumnName("GiaSP");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDHD");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.HasKey("IDHDCT");

                    b.HasIndex("IDHD");

                    b.HasIndex("IDSPCT");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.PhuongThucThanhToan", b =>
                {
                    b.Property<Guid>("IDPTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenPhuongThuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDPTTT");

                    b.ToTable("PhuongThucThanhToan", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.Sale", b =>
                {
                    b.Property<Guid>("MaSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaTri")
                        .HasColumnType("float")
                        .HasColumnName("GiaTri");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayBatDau");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("DateTime")
                        .HasColumnName("NgayketThuc");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.Property<string>("TenSale")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("TenSale");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaSale");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.SanPham", b =>
                {
                    b.Property<Guid>("IDSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaSP")
                        .HasColumnType("float")
                        .HasColumnName("GiaSP");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int")
                        .HasColumnName("SoLuongTon");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("TenSP");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("IDSP");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.SanPhamChiTiet", b =>
                {
                    b.Property<Guid>("IDSPCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaSP")
                        .HasColumnType("float")
                        .HasColumnName("GiaSP");

                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiSP")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("LoaiSP");

                    b.Property<Guid>("MaSale")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("MaSale");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.Property<string>("TenSPCT")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("TenSPCT");

                    b.HasKey("IDSPCT");

                    b.HasIndex("IDSP");

                    b.HasIndex("MaSale");

                    b.ToTable("SanPhamChiTiet", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("Nvarchar(10)")
                        .HasColumnName("ChucVu");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("DiaChi");

                    b.Property<string>("Matkhau")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("MatKhau");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("Nvarchar(50)")
                        .HasColumnName("SoDienThoai");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("TenNguoiDung");

                    b.HasKey("UserID");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.Voucher", b =>
                {
                    b.Property<Guid>("IDVouncher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DieuKien")
                        .HasColumnType("int")
                        .HasColumnName("DieuKien");

                    b.Property<double>("GiaTri")
                        .HasColumnType("float")
                        .HasColumnName("GiaTri");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("Soluong");

                    b.Property<string>("TenVouncher")
                        .IsRequired()
                        .HasColumnType("Nvarchar(max)")
                        .HasColumnName("TenVouncher");

                    b.HasKey("IDVouncher");

                    b.ToTable("Vouncher", (string)null);
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.GioHang", b =>
                {
                    b.HasOne("App_Data_ClassLib.Models.User", "Users")
                        .WithOne("GioHangs")
                        .HasForeignKey("App_Data_ClassLib.Models.GioHang", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("App_Data_ClassLib.Models.SanPhamChiTiet", "SanPhamChiTiets")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SanPhamChiTiet_GioHangChiTiet");

                    b.HasOne("App_Data_ClassLib.Models.GioHang", "GioHangs")
                        .WithMany("GioHangChiTiet")
                        .HasForeignKey("IDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHangs");

                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.HoaDon", b =>
                {
                    b.HasOne("App_Data_ClassLib.Models.Voucher", "Vounchers")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDVouncher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Vouncher_HDs");

                    b.HasOne("App_Data_ClassLib.Models.User", "Users")
                        .WithMany("HoaDons")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");

                    b.Navigation("Vounchers");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("App_Data_ClassLib.Models.HoaDon", "HoaDons")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HoaDons_HDCTS");

                    b.HasOne("App_Data_ClassLib.Models.SanPhamChiTiet", "SanPhamChiTiets")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SanPhamChiTiet_HDCT");

                    b.Navigation("HoaDons");

                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.PhuongThucThanhToan", b =>
                {
                    b.HasOne("App_Data_ClassLib.Models.HoaDon", "HoaDons")
                        .WithMany("PhuongThucThanhToans")
                        .HasForeignKey("IDPTTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_PTTT_HoaDons");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("App_Data_ClassLib.Models.SanPham", "SanPham")
                        .WithMany("SanPhamChiTiet")
                        .HasForeignKey("IDSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SanPham_SanPhamChiTiet");

                    b.HasOne("App_Data_ClassLib.Models.Sale", "Sales")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("MaSale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Sales_Users");

                    b.Navigation("Sales");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiet");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");

                    b.Navigation("PhuongThucThanhToans");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.Sale", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.SanPham", b =>
                {
                    b.Navigation("SanPhamChiTiet");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.SanPhamChiTiet", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.User", b =>
                {
                    b.Navigation("GioHangs")
                        .IsRequired();

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("App_Data_ClassLib.Models.Voucher", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
