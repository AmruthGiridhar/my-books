﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using my_books.Data;

namespace my_books.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("my_books.Data.Models.Author", b =>
                {
                    b.Property<int>("authorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("authorFullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("authorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("my_books.Data.Models.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bookCoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("bookDateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("bookDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("bookRate")
                        .HasColumnType("int");

                    b.Property<string>("bookTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateRead")
                        .HasColumnType("datetime2");

                    b.Property<string>("genere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isRead")
                        .HasColumnType("bit");

                    b.Property<int>("publisherId")
                        .HasColumnType("int");

                    b.HasKey("bookId");

                    b.HasIndex("publisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("my_books.Data.Models.book_Author", b =>
                {
                    b.Property<int>("bookAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("authorId")
                        .HasColumnType("int");

                    b.Property<int>("bookId")
                        .HasColumnType("int");

                    b.HasKey("bookAuthorId");

                    b.HasIndex("authorId");

                    b.HasIndex("bookId");

                    b.ToTable("books_Authors");
                });

            modelBuilder.Entity("my_books.Data.Models.publisher", b =>
                {
                    b.Property<int>("publisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("publisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("publisherId");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("my_books.Data.Models.Book", b =>
                {
                    b.HasOne("my_books.Data.Models.publisher", "publisher")
                        .WithMany("books")
                        .HasForeignKey("publisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("publisher");
                });

            modelBuilder.Entity("my_books.Data.Models.book_Author", b =>
                {
                    b.HasOne("my_books.Data.Models.Author", "author")
                        .WithMany("book_Authors")
                        .HasForeignKey("authorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("my_books.Data.Models.Book", "book")
                        .WithMany("book_Authors")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("book");
                });

            modelBuilder.Entity("my_books.Data.Models.Author", b =>
                {
                    b.Navigation("book_Authors");
                });

            modelBuilder.Entity("my_books.Data.Models.Book", b =>
                {
                    b.Navigation("book_Authors");
                });

            modelBuilder.Entity("my_books.Data.Models.publisher", b =>
                {
                    b.Navigation("books");
                });
#pragma warning restore 612, 618
        }
    }
}
