﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Properties.Context;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Properties.Models.Project", b =>
                {
                    b.Property<int>("IdProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProject"));

                    b.Property<int>("IdDefaultAssignee")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProject");

                    b.HasIndex("IdDefaultAssignee");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebApplication2.Properties.Models.TaskT", b =>
                {
                    b.Property<int>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTask"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("IdAssignee")
                        .HasColumnType("int");

                    b.Property<int>("IdProject")
                        .HasColumnType("int");

                    b.Property<int>("IdReporter")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdTask");

                    b.HasIndex("IdAssignee");

                    b.HasIndex("IdProject");

                    b.HasIndex("IdReporter");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("WebApplication2.Properties.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication2.Properties.Models.Project", b =>
                {
                    b.HasOne("WebApplication2.Properties.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("IdDefaultAssignee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication2.Properties.Models.TaskT", b =>
                {
                    b.HasOne("WebApplication2.Properties.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdAssignee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Properties.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("IdProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Properties.Models.User", "UserReporter")
                        .WithMany()
                        .HasForeignKey("IdReporter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");

                    b.Navigation("UserReporter");
                });

            modelBuilder.Entity("WebApplication2.Properties.Models.User", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
