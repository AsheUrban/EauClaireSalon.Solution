﻿// <auto-generated />
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HairSalon.Migrations
{
    [DbContext(typeof(HairSalonContext))]
    [Migration("20220803210345_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HairSalon.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactInfo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DateOfLastApp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("StylistId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("HairSalon.Models.Stylist", b =>
                {
                    b.Property<int>("StylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Specialty")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StylistId");

                    b.ToTable("Stylists");
                });

            modelBuilder.Entity("HairSalon.Models.StylistClient", b =>
                {
                    b.Property<int>("StylistClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("StylistId")
                        .HasColumnType("int");

                    b.HasKey("StylistClientId");

                    b.HasIndex("ClientId");

                    b.HasIndex("StylistId");

                    b.ToTable("StylistClient");
                });

            modelBuilder.Entity("HairSalon.Models.StylistClient", b =>
                {
                    b.HasOne("HairSalon.Models.Client", "Client")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HairSalon.Models.Stylist", "Stylist")
                        .WithMany("JoinEntities")
                        .HasForeignKey("StylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Stylist");
                });

            modelBuilder.Entity("HairSalon.Models.Client", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("HairSalon.Models.Stylist", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
