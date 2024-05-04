﻿// <auto-generated />
using EduSpot.Services.MaterialAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduSpot.Services.MaterialAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240429142245_addData")]
    partial class addData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EduSpot.Services.MaterialAPI.Models.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"));

                    b.Property<string>("ArbicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountHours")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PdfLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PdfUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortCut")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            MaterialId = 1,
                            ArbicName = "مهارات الحاسوب",
                            CountHours = 4,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Computer Skills",
                            ShortCut = "GBS101"
                        },
                        new
                        {
                            MaterialId = 2,
                            ArbicName = "مقدمة في البرمجة",
                            CountHours = 4,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Introduction to Programming",
                            ShortCut = "IPG101"
                        },
                        new
                        {
                            MaterialId = 3,
                            ArbicName = "مقدمة في التعليم الإلكتروني",
                            CountHours = 4,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Introduction on-Line Education",
                            ShortCut = "GBS103"
                        },
                        new
                        {
                            MaterialId = 4,
                            ArbicName = "التحليل الرياضي ",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Mathe matical Analysls",
                            ShortCut = "GMA101"
                        },
                        new
                        {
                            MaterialId = 5,
                            ArbicName = "مقدمة في نمذجة المعطيات",
                            CountHours = 4,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Introduction to Data Modeling",
                            ShortCut = "IIS101"
                        },
                        new
                        {
                            MaterialId = 6,
                            ArbicName = "تقانات التجارة الإلكترونية ",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "E-Commerce Technologles",
                            ShortCut = "IWB101"
                        },
                        new
                        {
                            MaterialId = 7,
                            ArbicName = "البرمجة الإجرائية",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Procedural Programming",
                            ShortCut = "IPG202"
                        },
                        new
                        {
                            MaterialId = 8,
                            ArbicName = "مقدمة في الشبكات",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Introduction to Networks",
                            ShortCut = "INT101"
                        },
                        new
                        {
                            MaterialId = 9,
                            ArbicName = "مقدمة في نظم التشغيل",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Introduction to Operating Systems",
                            ShortCut = "IOS101"
                        },
                        new
                        {
                            MaterialId = 10,
                            ArbicName = "إلكترونيات رقمية",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Digital Electronics",
                            ShortCut = "GDE101"
                        },
                        new
                        {
                            MaterialId = 11,
                            ArbicName = "تصميم وبنيان قواعد المعطيات ",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Database Archltecture and Design",
                            ShortCut = "IIS201"
                        },
                        new
                        {
                            MaterialId = 12,
                            ArbicName = "تحضير السيرة المهنية",
                            CountHours = 3,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Career Preparation",
                            ShortCut = "GBS102"
                        },
                        new
                        {
                            MaterialId = 13,
                            ArbicName = "تصميم وتطوير تطبيقات الويب",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Web Application Development and Design",
                            ShortCut = "IWB201"
                        },
                        new
                        {
                            MaterialId = 14,
                            ArbicName = "نظم التشغيل الشبكية ",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Network Operating System",
                            ShortCut = "IOS201"
                        },
                        new
                        {
                            MaterialId = 15,
                            ArbicName = "البرمجة مقادة بالأحداث",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Event Driven Programming",
                            ShortCut = "IPG201"
                        },
                        new
                        {
                            MaterialId = 16,
                            ArbicName = "التصميم والبرمجة غرضية التوجه",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Object Oriented Programming",
                            ShortCut = "IPG203"
                        },
                        new
                        {
                            MaterialId = 17,
                            ArbicName = "البرمجة المتقدمة بلغة SQL",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Advanced SQL Programming",
                            ShortCut = "IIS202"
                        },
                        new
                        {
                            MaterialId = 18,
                            ArbicName = "منصة ويندز",
                            CountHours = 5,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "windows Platform",
                            ShortCut = "IOS202"
                        },
                        new
                        {
                            MaterialId = 19,
                            ArbicName = "منصة لينوكس",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Linux Platform ",
                            ShortCut = "IOS203"
                        },
                        new
                        {
                            MaterialId = 20,
                            ArbicName = "إدارة قواعد بيانات",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "MS-SQL Server Administration ",
                            ShortCut = "IIS303"
                        },
                        new
                        {
                            MaterialId = 21,
                            ArbicName = "إدارة قواعد بيانات Oracle",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Oracle Database Administration ",
                            ShortCut = "IIS203"
                        },
                        new
                        {
                            MaterialId = 22,
                            ArbicName = "برمجة التطبيقات النقالة",
                            CountHours = 6,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "Mobile Programming",
                            ShortCut = "IPG204"
                        },
                        new
                        {
                            MaterialId = 23,
                            ArbicName = "مشروع",
                            CountHours = 12,
                            Description = "Description",
                            ImageUrl = "https://placehold.co/603x403",
                            MajorId = 1,
                            Name = "TIC Final Project",
                            ShortCut = "IPI201"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
