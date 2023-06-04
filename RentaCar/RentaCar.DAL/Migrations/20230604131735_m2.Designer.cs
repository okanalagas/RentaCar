﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentaCar.DAL.Context;

#nullable disable

namespace RentaCar.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230604131735_m2")]
    partial class m2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentaCar.Entities.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Marka");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturma Tarihi");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Silme Tarihi");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Açıklama");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Yakıt Tipi");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Resim Adresi");

                    b.Property<int>("Km")
                        .HasColumnType("int")
                        .HasColumnName("Km");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Model");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int")
                        .HasColumnName("Model Yılı");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncelleme Tarihi");

                    b.Property<decimal>("Rental")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Kiralama Ücreti");

                    b.Property<int>("Seat")
                        .HasColumnType("int")
                        .HasColumnName("Koltuk Sayısı");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Veri Durumu");

                    b.Property<string>("TransmissionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Vites Tipi");

                    b.Property<bool>("isRented")
                        .HasColumnType("bit")
                        .HasColumnName("Kirada mı");

                    b.HasKey("Id");

                    b.ToTable("Araçlar", (string)null);
                });

            modelBuilder.Entity("RentaCar.Entities.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Adres");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturma Tarihi");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Silme Tarihi");

                    b.Property<string>("DriverLicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ehliyet Numarası");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Mail Adresi");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ad");

                    b.Property<int?>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("Cinsiyet");

                    b.Property<long>("IdentityNo")
                        .HasColumnType("bigint")
                        .HasColumnName("Tc Kimlik Numarası");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Soyad");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncelleme Tarihi");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Şifre");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Telefon Numarası");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Veri Durumu");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Kullanıcı Adı");

                    b.HasKey("Id");

                    b.ToTable("Müşteriler", (string)null);
                });

            modelBuilder.Entity("RentaCar.Entities.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("Araç Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturma Tarihi");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Müşteri Id");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Silme Tarihi");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Araç Teslim Tarihi");

                    b.Property<string>("DropOffOffice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Araç Teslim Ofisi");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncelleme Tarihi");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Araç Alım Tarihi");

                    b.Property<string>("PickUpOffice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Araç Alım Ofisi");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Veri Durumu");

                    b.Property<decimal>("TotalRental")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Toplam Kiralama Tutarı");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Siparişler", (string)null);
                });

            modelBuilder.Entity("RentaCar.Entities.Models.Order", b =>
                {
                    b.HasOne("RentaCar.Entities.Models.Car", "Car")
                        .WithMany("Orders")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentaCar.Entities.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RentaCar.Entities.Models.Car", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RentaCar.Entities.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}