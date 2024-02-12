﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(ControleContext))]
    partial class ControleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("API.Entities.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adresse")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodePostal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Departement")
                        .HasColumnType("TEXT");

                    b.Property<string>("Energie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<long>("Prix")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PrixMaxCV")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PrixMinCV")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SiteWeb")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeVehicule")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ville")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Garages");
                });
#pragma warning restore 612, 618
        }
    }
}
