﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191202101732_SeedValues")]
    partial class SeedValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("Domain.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "This is the new weather",
                            TemperatureC = 29
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "This is so normal",
                            TemperatureC = 35
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "This is a really cold weather",
                            TemperatureC = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
