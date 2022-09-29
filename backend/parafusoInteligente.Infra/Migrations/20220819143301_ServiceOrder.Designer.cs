﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using parafusoInteligente.Infra;

namespace parafusoInteligente.Infra.Migrations
{
    [DbContext(typeof(parafusoInteligenteContext))]
    [Migration("20220819143301_ServiceOrder")]
    partial class ServiceOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("parafusoInteligente.Infra.Entities.ConsumerUnitEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Addres")
                        .HasColumnType("text")
                        .HasColumnName("ADDRES");

                    b.Property<string>("ConsumerGroup")
                        .HasColumnType("text")
                        .HasColumnName("CONSUMER_GROUP");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text")
                        .HasColumnName("COORDINATES");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CREATED_AT");

                    b.Property<int>("MeterCode")
                        .HasColumnType("integer")
                        .HasColumnName("METER_CODE");

                    b.Property<string>("Region")
                        .HasColumnType("text")
                        .HasColumnName("REGION");

                    b.Property<string>("Screws")
                        .HasColumnType("text")
                        .HasColumnName("SCREWS");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UPDATED_AT");

                    b.HasKey("Id");

                    b.ToTable("T_CONSUMERUNIT");
                });

            modelBuilder.Entity("parafusoInteligente.Infra.Entities.ServiceOrderEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Addres")
                        .HasColumnType("text")
                        .HasColumnName("ADDRES");

                    b.Property<string>("Cdc")
                        .HasColumnType("text")
                        .HasColumnName("CDC");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("Meter")
                        .HasColumnType("text")
                        .HasColumnName("METER");

                    b.Property<int>("Os")
                        .HasColumnType("integer")
                        .HasColumnName("OS");

                    b.Property<string>("Service")
                        .HasColumnType("text")
                        .HasColumnName("SERVICE");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UPDATED_AT");

                    b.HasKey("Id");

                    b.ToTable("T_SERVICEORDER");
                });

            modelBuilder.Entity("parafusoInteligente.Infra.Entities.StockManagementEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("IDENTIFIER");

                    b.Property<string>("LastAccess")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("LAST_ACCESS");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("LOCATION");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("STATUS");

                    b.Property<string>("StockStatus")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("STOCK_STATUS");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("TYPE");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UPDATED_AT");

                    b.HasKey("Id");

                    b.ToTable("T_STOCKMANAGEMENT");
                });

            modelBuilder.Entity("parafusoInteligente.Infra.Entities.SyncEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("CREATED_AT");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("GROUP");

                    b.Property<string>("Screws")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("SCREWS");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("UPDATED_AT");

                    b.HasKey("Id");

                    b.ToTable("T_SYNC");
                });
#pragma warning restore 612, 618
        }
    }
}
