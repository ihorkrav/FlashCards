﻿// <auto-generated />
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlashCards.Migrations
{
    [DbContext(typeof(DeckDbContext))]
    [Migration("20231101103706_card_data")]
    partial class card_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FlashCards.Data.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BackData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeckID")
                        .HasColumnType("int");

                    b.Property<string>("FrontData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackData = "4",
                            DeckID = 1,
                            FrontData = "2+2 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            BackData = "4",
                            DeckID = 1,
                            FrontData = "2*2 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 3,
                            BackData = "4",
                            DeckID = 1,
                            FrontData = "2^2 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            BackData = "16",
                            DeckID = 1,
                            FrontData = "4*4 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 5,
                            BackData = "9",
                            DeckID = 1,
                            FrontData = "3^2 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 6,
                            BackData = "17",
                            DeckID = 1,
                            FrontData = "9+8 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 7,
                            BackData = "33",
                            DeckID = 1,
                            FrontData = "22+11 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 8,
                            BackData = "81",
                            DeckID = 1,
                            FrontData = "33+48 = ?",
                            Priority = 1
                        },
                        new
                        {
                            Id = 9,
                            BackData = "60",
                            DeckID = 1,
                            FrontData = "55+5 = ?",
                            Priority = 1
                        });
                });

            modelBuilder.Entity("FlashCards.Data.Entities.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountOfCards")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Decks");
                });
#pragma warning restore 612, 618
        }
    }
}