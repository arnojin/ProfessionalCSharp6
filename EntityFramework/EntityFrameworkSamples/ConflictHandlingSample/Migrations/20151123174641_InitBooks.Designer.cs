using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BooksSample;

namespace ConflictHandlingSample.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20151123174641_InitBooks")]
    partial class InitBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BooksSample.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Publisher")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Relational:ColumnType", "timestamp");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 120);

                    b.HasKey("BookId");
                });
        }
    }
}
