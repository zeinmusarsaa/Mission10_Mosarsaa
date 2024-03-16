﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission10_Zein.Models;

#nullable disable

namespace Mission10_Zein.Migrations
{
    [DbContext(typeof(BowlingLeagueContext))]
    [Migration("20240316031237_secondOne")]
    partial class secondOne
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Mission10_Zein.Models.Bowler", b =>
                {
                    b.Property<int>("BowlerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("BowlerID");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("nvarchar (1)");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("nvarchar (14)");

                    b.Property<string>("BowlerState")
                        .HasColumnType("nvarchar (2)");

                    b.Property<string>("BowlerZip")
                        .HasColumnType("nvarchar (10)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INT")
                        .HasColumnName("TeamID");

                    b.HasKey("BowlerId");

                    b.HasIndex(new[] { "BowlerLastName" }, "BowlerLastName");

                    b.HasIndex(new[] { "TeamId" }, "BowlersTeamID");

                    b.ToTable("Bowlers");
                });

            modelBuilder.Entity("Mission10_Zein.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("TeamID");

                    b.Property<int?>("CaptainId")
                        .HasColumnType("INT")
                        .HasColumnName("CaptainID");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar (50)");

                    b.HasKey("TeamId");

                    b.HasIndex(new[] { "TeamId" }, "TeamID")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Mission10_Zein.Models.Bowler", b =>
                {
                    b.HasOne("Mission10_Zein.Models.Team", "Team")
                        .WithMany("Bowlers")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Mission10_Zein.Models.Team", b =>
                {
                    b.Navigation("Bowlers");
                });
#pragma warning restore 612, 618
        }
    }
}
