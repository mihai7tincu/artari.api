﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using artari.entities;

#nullable disable

namespace artari.entities.Migrations
{
    [DbContext(typeof(ArtariDbContext))]
    [Migration("20250106131459_ProductSeed")]
    partial class ProductSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("artari")
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("artari.entities.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cultivar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSoldout")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Propagation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Species")
                        .HasColumnType("int");

                    b.Property<string>("SpeciesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product", "artari");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Cultivar = "Bloodgood",
                            Description = "red leaves",
                            Height = "22",
                            ImageUrl = "img artar Bloodgood",
                            IsNew = false,
                            IsSoldout = false,
                            Name = "Acer palmatum Bloodgood",
                            Price = 55.0,
                            Priority = 1,
                            Propagation = "propagation details for Bloodgood",
                            Species = 0,
                            SpeciesName = "Palmatum",
                            Type = 0,
                            TypeName = "Acer"
                        },
                        new
                        {
                            Id = -2,
                            Cultivar = "Atropurpureum",
                            Description = "red leaves",
                            Height = "22",
                            ImageUrl = "img artar Atropurpureum",
                            IsNew = false,
                            IsSoldout = false,
                            Name = "Acer dissectum Atropurpureum",
                            Price = 58.0,
                            Priority = 2,
                            Propagation = "propagation details for Atropurpureum",
                            Species = 1,
                            SpeciesName = "Dissectum",
                            Type = 0,
                            TypeName = "Acer"
                        },
                        new
                        {
                            Id = -3,
                            Cultivar = "Green Cascade",
                            Description = "green leaves",
                            Height = "22",
                            ImageUrl = "img artar Green Cascade",
                            IsNew = false,
                            IsSoldout = false,
                            Name = "Acer japonicum Green Cascade",
                            Price = 12.800000000000001,
                            Priority = 1,
                            Propagation = "propagation details for Green Cascade",
                            Species = 3,
                            SpeciesName = "Japonicum",
                            Type = 0,
                            TypeName = "Acer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
