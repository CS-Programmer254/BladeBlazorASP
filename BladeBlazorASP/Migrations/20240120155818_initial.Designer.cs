﻿// <auto-generated />
using System;
using BladeBlazorASP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BladeBlazorASP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240120155818_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BladeBlazorASP.Models.EmailSubscribers", b =>
                {
                    b.Property<Guid>("SubscriberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubscriber")
                        .HasColumnType("bit");

                    b.HasKey("SubscriberID");

                    b.ToTable("EmailSubscribers");
                });
#pragma warning restore 612, 618
        }
    }
}
