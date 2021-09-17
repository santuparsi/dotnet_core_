﻿// <auto-generated />
using System;
using HandsOnEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HandsOnEFCodeFirst.Migrations
{
    [DbContext(typeof(EmployeeDBContext))]
    [Migration("20210909101314_AddedDesig")]
    partial class AddedDesig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandsOnEFCodeFirst.Entities.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desig")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)")
                        .HasColumnName("Designation");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("JoinDate")
                        .HasColumnType("Date");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}