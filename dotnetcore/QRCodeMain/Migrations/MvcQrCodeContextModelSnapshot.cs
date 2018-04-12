﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using QRCodeMain.Models;
using System;

namespace QRCodeMain.Migrations
{
    [DbContext(typeof(MvcQrCodeContext))]
    partial class MvcQrCodeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("QRCodeMain.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("QrCodeId");

                    b.Property<string>("Title");

                    b.Property<string>("UserName");

                    b.HasKey("ArticleId");

                    b.HasIndex("QrCodeId")
                        .IsUnique();

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("QRCodeMain.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Title");

                    b.HasKey("CategoryId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QRCodeMain.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Content");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("QRCodeMain.Models.QrCode", b =>
                {
                    b.Property<int>("QrCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("QrCodeRelativePath");

                    b.HasKey("QrCodeId");

                    b.ToTable("QrCode");
                });

            modelBuilder.Entity("QRCodeMain.Models.UserTag", b =>
                {
                    b.Property<int>("UserTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Title");

                    b.HasKey("UserTagId");

                    b.HasIndex("ArticleId");

                    b.ToTable("UserTags");
                });

            modelBuilder.Entity("QRCodeMain.Models.Article", b =>
                {
                    b.HasOne("QRCodeMain.Models.QrCode", "QrCode")
                        .WithOne("Article")
                        .HasForeignKey("QRCodeMain.Models.Article", "QrCodeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QRCodeMain.Models.Category", b =>
                {
                    b.HasOne("QRCodeMain.Models.Article")
                        .WithMany("Categories")
                        .HasForeignKey("ArticleId");
                });

            modelBuilder.Entity("QRCodeMain.Models.Comment", b =>
                {
                    b.HasOne("QRCodeMain.Models.Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");
                });

            modelBuilder.Entity("QRCodeMain.Models.UserTag", b =>
                {
                    b.HasOne("QRCodeMain.Models.Article")
                        .WithMany("UserTags")
                        .HasForeignKey("ArticleId");
                });
#pragma warning restore 612, 618
        }
    }
}
