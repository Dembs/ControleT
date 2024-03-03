﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(ControleContext))]
    [Migration("20240301185235_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("API.Entities.Field", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctAdresse")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctCodeCommune")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctDenomination")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctSiret")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctTel")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeDepartement")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodePostal")
                        .HasColumnType("TEXT");

                    b.Property<long>("CodeRegion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Departement")
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("API.Entities.Record", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("FieldsId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FieldsId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("API.Entities.Record", b =>
                {
                    b.HasOne("API.Entities.Field", "Fields")
                        .WithMany()
                        .HasForeignKey("FieldsId");

                    b.Navigation("Fields");
                });
#pragma warning restore 612, 618
        }
    }
}