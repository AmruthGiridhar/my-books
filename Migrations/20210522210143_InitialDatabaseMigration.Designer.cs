// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using my_books.Data;

namespace my_books.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210522210143_InitialDatabaseMigration")]
    partial class InitialDatabaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("my_books.Data.Models.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bookAuthor")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("bookId");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
