﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OP_P6.Data;

#nullable disable

namespace OP_P6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OP_P6.Data.Entities.OperatingSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperatingSystems");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("OperatingSystemId")
                        .HasColumnType("int");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Resolved")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VersionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperatingSystemId");

                    b.HasIndex("VersionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Version", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("OperatingSystemVersion", b =>
                {
                    b.Property<int>("OperatingSystemsId")
                        .HasColumnType("int");

                    b.Property<int>("VersionsId")
                        .HasColumnType("int");

                    b.HasKey("OperatingSystemsId", "VersionsId");

                    b.HasIndex("VersionsId");

                    b.ToTable("OperatingSystemVersion");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Ticket", b =>
                {
                    b.HasOne("OP_P6.Data.Entities.OperatingSystem", "OperatingSystem")
                        .WithMany("Tickets")
                        .HasForeignKey("OperatingSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OP_P6.Data.Entities.Version", "Version")
                        .WithMany("Tickets")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperatingSystem");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Version", b =>
                {
                    b.HasOne("OP_P6.Data.Entities.Product", "Product")
                        .WithMany("Versions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OperatingSystemVersion", b =>
                {
                    b.HasOne("OP_P6.Data.Entities.OperatingSystem", null)
                        .WithMany()
                        .HasForeignKey("OperatingSystemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OP_P6.Data.Entities.Version", null)
                        .WithMany()
                        .HasForeignKey("VersionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OP_P6.Data.Entities.OperatingSystem", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Product", b =>
                {
                    b.Navigation("Versions");
                });

            modelBuilder.Entity("OP_P6.Data.Entities.Version", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
