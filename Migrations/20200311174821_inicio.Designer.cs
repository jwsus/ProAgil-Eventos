﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProaAgil.API.Data;

namespace ProaAgil.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200311174821_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("ProaAgil.API.Model.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lot")
                        .HasColumnType("TEXT");

                    b.Property<string>("Place")
                        .HasColumnType("TEXT");

                    b.Property<string>("Theme")
                        .HasColumnType("TEXT");

                    b.Property<int>("amountPerson")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
