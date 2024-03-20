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

            modelBuilder.Entity("API.Entities.Field", b =>
                {
                    b.Property<string>("CctSiret")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctAdresse")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctCodeCommune")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctDenomination")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctTel")
                        .HasColumnType("TEXT");

                    b.Property<string>("CctUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeDepartement")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodePostal")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodeRegion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Departement")
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .HasColumnType("TEXT");

                    b.HasKey("CctSiret");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("API.Entities.Record", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("FieldsCctSiret")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FieldsCctSiret");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("API.Entities.Record", b =>
                {
                    b.HasOne("API.Entities.Field", "Fields")
                        .WithMany()
                        .HasForeignKey("FieldsCctSiret");

                    b.Navigation("Fields");
                });
#pragma warning restore 612, 618
        }
    }
}
