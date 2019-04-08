﻿// <auto-generated />
using System;
using Airplane.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airplane.Data.Migrations
{
    [DbContext(typeof(AirplaneContext))]
    [Migration("20190403023656_initital")]
    partial class initital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airplane.Domain.Entities.Airplane", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("NumberOfPassengers");

                    b.HasKey("Id");

                    b.ToTable("Airplane");
                });
#pragma warning restore 612, 618
        }
    }
}