﻿// <auto-generated />
using EPass.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EPass.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231219220211_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("EPass.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InventoryNum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("passLabId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("passLabId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("EPass.Models.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("passLabId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("passLabId");

                    b.ToTable("Furnitures");
                });

            modelBuilder.Entity("EPass.Models.PassLab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressLab")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CodEquipment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FurnitureId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameLab")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumLab")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResponsibleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pass");
                });

            modelBuilder.Entity("EPass.Models.Responsible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Responsibles");
                });

            modelBuilder.Entity("EPass.Models.Equipment", b =>
                {
                    b.HasOne("EPass.Models.PassLab", "passLab")
                        .WithMany("Equipment")
                        .HasForeignKey("passLabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("passLab");
                });

            modelBuilder.Entity("EPass.Models.Furniture", b =>
                {
                    b.HasOne("EPass.Models.PassLab", "passLab")
                        .WithMany("Furniture")
                        .HasForeignKey("passLabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("passLab");
                });

            modelBuilder.Entity("EPass.Models.PassLab", b =>
                {
                    b.Navigation("Equipment");

                    b.Navigation("Furniture");
                });
#pragma warning restore 612, 618
        }
    }
}
