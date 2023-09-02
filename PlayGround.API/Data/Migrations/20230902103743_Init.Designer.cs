﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayGround.API.Data;

#nullable disable

namespace PlayGround.API.Data.Migrations
{
    [DbContext(typeof(PlayGroundDbContext))]
    [Migration("20230902103743_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("PlayGround.API.Models.ImageInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PosterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SavedName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PosterId");

                    b.ToTable("ImageInfos");
                });

            modelBuilder.Entity("PlayGround.API.Models.Poster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posters");
                });

            modelBuilder.Entity("PlayGround.API.Models.ImageInfo", b =>
                {
                    b.HasOne("PlayGround.API.Models.Poster", null)
                        .WithMany("Photos")
                        .HasForeignKey("PosterId");
                });

            modelBuilder.Entity("PlayGround.API.Models.Poster", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}