﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealtyWebApplication.EF;

namespace RealtyWebApplication.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230625114813_fixbug")]
    partial class fixbug
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealtyWebApplication.Core.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OwnerName")
                        .IsRequired();

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("RealtyWebApplication.Core.Models.Realty", b =>
                {
                    b.Property<int>("RealtyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OwnerId");

                    b.Property<string>("RealtyName")
                        .IsRequired();

                    b.Property<int>("RealtyPrice");

                    b.HasKey("RealtyId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Realties");
                });

            modelBuilder.Entity("RealtyWebApplication.Core.Models.Realty", b =>
                {
                    b.HasOne("RealtyWebApplication.Core.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
