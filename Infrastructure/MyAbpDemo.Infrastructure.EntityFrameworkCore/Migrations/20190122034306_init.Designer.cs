﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAbpDemo.Infrastructure.EFCore;

namespace MyAbpDemo.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(MyAbpDemoDbContext))]
    [Migration("20190122034306_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyAbpDemo.Core.AuditInfoLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrowserInfo");

                    b.Property<string>("ClientIpAddress");

                    b.Property<string>("ClientName");

                    b.Property<string>("CustomData");

                    b.Property<string>("Exception");

                    b.Property<int>("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime");

                    b.Property<int?>("ImpersonatorTenantId");

                    b.Property<long?>("ImpersonatorUserId");

                    b.Property<string>("MethodName");

                    b.Property<string>("Parameters");

                    b.Property<string>("ServiceName");

                    b.Property<int?>("TenantId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AuditInfoLog");
                });

            modelBuilder.Entity("MyAbpDemo.Core.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Blog");

                    b.HasData(
                        new { Id = 1, Url = "www.baidu.com" }
                    );
                });

            modelBuilder.Entity("MyAbpDemo.Core.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogUrl");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BlogUrl");

                    b.ToTable("Post");

                    b.HasData(
                        new { Id = 1, BlogUrl = "www.baidu.com", Content = "6.15准时下班", Title = "下班了" },
                        new { Id = 2, BlogUrl = "www.baidu.com", Content = "2.5过年了", Title = "过年了" }
                    );
                });

            modelBuilder.Entity("MyAbpDemo.Core.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<byte>("LearnLevel");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new { Id = 1L, Age = 18, CreationTime = new DateTime(2019, 1, 22, 11, 43, 5, 741, DateTimeKind.Local), IsActive = true, IsDeleted = false, LearnLevel = (byte)1, Name = "学生1", TeacherId = 1L },
                        new { Id = 2L, Age = 36, CreationTime = new DateTime(2019, 1, 22, 11, 43, 5, 742, DateTimeKind.Local), IsActive = true, IsDeleted = false, LearnLevel = (byte)4, Name = "学生2", TeacherId = 1L }
                    );
                });

            modelBuilder.Entity("MyAbpDemo.Core.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsReview");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new { Id = 1L, Age = 18, CreationTime = new DateTime(2019, 1, 22, 11, 43, 5, 739, DateTimeKind.Local), IsActive = true, IsDeleted = false, IsReview = true, Name = "朱老师" }
                    );
                });

            modelBuilder.Entity("MyAbpDemo.Core.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("Emial");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Nickname");

                    b.Property<string>("Password");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = 1L, CreationTime = new DateTime(2019, 1, 22, 11, 43, 5, 743, DateTimeKind.Local), Emial = "jianlive@sina.com", IsActive = true, IsDeleted = false, Nickname = "小名test1", Password = "123", UserName = "test1" }
                    );
                });

            modelBuilder.Entity("MyAbpDemo.Core.Post", b =>
                {
                    b.HasOne("MyAbpDemo.Core.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogUrl")
                        .HasPrincipalKey("Url")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyAbpDemo.Core.Student", b =>
                {
                    b.HasOne("MyAbpDemo.Core.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyAbpDemo.Core.User", b =>
                {
                    b.OwnsOne("MyAbpDemo.Core.Address", "Address", b1 =>
                        {
                            b1.Property<long?>("UserId");

                            b1.Property<int>("CityId")
                                .HasColumnName("CityId");

                            b1.Property<int>("Number")
                                .HasColumnName("Number");

                            b1.Property<string>("Street")
                                .HasColumnName("Street");

                            b1.ToTable("Adress");

                            b1.HasOne("MyAbpDemo.Core.User")
                                .WithOne("Address")
                                .HasForeignKey("MyAbpDemo.Core.Address", "UserId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new { UserId = 1L, CityId = 123, Number = 235, Street = "天顶街道" }
                            );
                        });
                });
#pragma warning restore 612, 618
        }
    }
}