﻿// <auto-generated />
using System;
using HestiaStore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HestiaStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250602195302_StructureUpdate")]
    partial class StructureUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HestiaStore.Entities.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("agencies");
                });

            modelBuilder.Entity("HestiaStore.Entities.Chat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Filter")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("chats");
                });

            modelBuilder.Entity("HestiaStore.Entities.DwellingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("dwelling_types");
                });

            modelBuilder.Entity("HestiaStore.Entities.EnergyLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("energy_labels");
                });

            modelBuilder.Entity("HestiaStore.Entities.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AgencyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int?>("DwellingTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("EnergyLabelId")
                        .HasColumnType("integer");

                    b.Property<bool?>("GasLess")
                        .HasColumnType("boolean");

                    b.Property<bool>("HasBalcony")
                        .HasColumnType("boolean");

                    b.Property<bool>("HasGarden")
                        .HasColumnType("boolean");

                    b.Property<bool>("HasStorageRoom")
                        .HasColumnType("boolean");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("HouseNumberAddition")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<int?>("LivinArea")
                        .HasColumnType("integer");

                    b.Property<int?>("MunicipalityId")
                        .HasColumnType("integer");

                    b.Property<bool>("NewlyBuild")
                        .HasColumnType("boolean");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<int?>("Rooms")
                        .HasColumnType("integer");

                    b.Property<bool?>("SolarPanels")
                        .HasColumnType("boolean");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("integer");

                    b.Property<bool?>("ZeroOnTheMeter")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("CityId");

                    b.HasIndex("DwellingTypeId");

                    b.HasIndex("EnergyLabelId");

                    b.HasIndex("MunicipalityId");

                    b.ToTable("homes");
                });

            modelBuilder.Entity("HestiaStore.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("locations");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("HestiaStore.Entities.TargetGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("AidHome")
                        .HasColumnType("boolean");

                    b.Property<int?>("MaxAge")
                        .HasColumnType("integer");

                    b.Property<int?>("MaximumOccupants")
                        .HasColumnType("integer");

                    b.Property<int?>("MinAge")
                        .HasColumnType("integer");

                    b.Property<int?>("MinimumOccupants")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("target_groups");
                });

            modelBuilder.Entity("HomeTargetGroup", b =>
                {
                    b.Property<int>("HomeId")
                        .HasColumnType("integer");

                    b.Property<int>("TargetGroupsId")
                        .HasColumnType("integer");

                    b.HasKey("HomeId", "TargetGroupsId");

                    b.HasIndex("TargetGroupsId");

                    b.ToTable("HomeTargetGroup");
                });

            modelBuilder.Entity("HestiaStore.Entities.City", b =>
                {
                    b.HasBaseType("HestiaStore.Entities.Location");

                    b.Property<int?>("GemeenteId")
                        .HasColumnType("integer");

                    b.HasIndex("GemeenteId");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("HestiaStore.Entities.Home", b =>
                {
                    b.HasOne("HestiaStore.Entities.Agency", "Agency")
                        .WithMany("Homes")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HestiaStore.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HestiaStore.Entities.DwellingType", "DwellingType")
                        .WithMany()
                        .HasForeignKey("DwellingTypeId");

                    b.HasOne("HestiaStore.Entities.EnergyLabel", "EnergyLabel")
                        .WithMany()
                        .HasForeignKey("EnergyLabelId");

                    b.HasOne("HestiaStore.Entities.Location", "Municipality")
                        .WithMany()
                        .HasForeignKey("MunicipalityId");

                    b.Navigation("Agency");

                    b.Navigation("City");

                    b.Navigation("DwellingType");

                    b.Navigation("EnergyLabel");

                    b.Navigation("Municipality");
                });

            modelBuilder.Entity("HomeTargetGroup", b =>
                {
                    b.HasOne("HestiaStore.Entities.Home", null)
                        .WithMany()
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HestiaStore.Entities.TargetGroup", null)
                        .WithMany()
                        .HasForeignKey("TargetGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HestiaStore.Entities.City", b =>
                {
                    b.HasOne("HestiaStore.Entities.Location", "Gemeente")
                        .WithMany()
                        .HasForeignKey("GemeenteId");

                    b.HasOne("HestiaStore.Entities.Location", null)
                        .WithOne()
                        .HasForeignKey("HestiaStore.Entities.City", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gemeente");
                });

            modelBuilder.Entity("HestiaStore.Entities.Agency", b =>
                {
                    b.Navigation("Homes");
                });
#pragma warning restore 612, 618
        }
    }
}
