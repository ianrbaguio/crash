﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Crash.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal;

#nullable disable

namespace Crash.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Crash.Models.Entities.Accident", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AccidentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("AccidentId")
                        .HasColumnType("integer");

                    b.Property<string>("Daylight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("EstimatedCost")
                        .HasColumnType("double precision");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");
                 
                    b.Property<string>("Weather")
                     .IsRequired()
                     .HasColumnType("text");

                    b.Property<string>("Latitude")
                       .IsRequired()
                       .HasColumnType("double precision");

                    b.Property<string>("Longitude")
                    .IsRequired()
                    .HasColumnType("double precision");

                    b.Property<int>("NumberOfParties")
                        .HasColumnType("integer");

                    b.Property<List<string>>("Parties")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("Id");

                    b.ToTable("accident");
                });


            modelBuilder.Entity("Crash.Models.Entities.Image", b =>
            {

                b.Property<int>("Id")
                         .ValueGeneratedOnAdd()
                         .HasColumnType("integer");

                b.Property<Guid>("AccidentId")
                    .HasColumnType("uuid");

                b.Property<NpgsqlByteArrayMethodTranslator>("ImageData")
                    .HasColumnType("integer");
              
                b.HasKey("Id");
                b.ToTable("image");
            });
#pragma warning restore 612, 618
        }
    }
}
