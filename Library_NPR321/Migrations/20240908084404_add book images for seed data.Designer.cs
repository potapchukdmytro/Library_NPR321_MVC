﻿// <auto-generated />
using System;
using Library_NPR321.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_NPR321.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240908084404_add book images for seed data")]
    partial class addbookimagesforseeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library_NPR321.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Джоан",
                            LastName = "Роулінг"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Джон Рональд Руел",
                            LastName = "Толкін"
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Стівен",
                            LastName = "Кінг"
                        });
                });

            modelBuilder.Entity("Library_NPR321.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<short>("Year")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Перший роман серії «Гаррі Поттер» британської письменниці Дж. К. Ролінґ. Опублікований 30 червня 1997 року видавництвом «Блумсбері Паблішинґ» у Лондоні. В 2001 році було випущено однойменний художній фільм на основі роману.",
                            Genre = "Епічне фентезі",
                            Image = "10ac9d5b-b28a-44c0-97ce-887533646261.jpg",
                            Language = "eng",
                            PageCount = 360,
                            Publisher = "КСД",
                            Title = "Гаррі Поттер і філософський камінь",
                            Year = (short)1997
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Другий роман серії «Гаррі Поттер» британської письменниці Дж. К. Ролінґ. Вийшов 2 липня 1998 року у видавництві «Блумсбері Паблішинґ» у Лондоні. 2002 року на основі роману знято однойменний художній фільм.",
                            Genre = "Епічне фентезі",
                            Image = "c4a53845-cb61-4168-8514-a28e15e27847.jpeg",
                            Language = "eng",
                            PageCount = 352,
                            Publisher = "КСД",
                            Title = "Гаррі Поттер і таємна кімната",
                            Year = (short)1998
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Description = "«Хранителі Персня» — перша частина роману англійського письменника Дж. Р. Р. Толкіна «Володар перснів», що публікується разом із прологом, який не входить до складу всієї книги. Складається з двох книг.",
                            Genre = "Фентезі",
                            Image = "c4a53845-cb61-4168-8514-a28e15e27847.jpeg",
                            Language = "eng",
                            PageCount = 704,
                            Publisher = "КСД",
                            Title = "Володар перснів братство персня",
                            Year = (short)1954
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "«Дві твердині» — друга частина трилогії англійського письменника Дж. Р. Р. Толкіна «Володар перснів». Складається з двох частин. Опублікована у 1954 році у Лондоні.",
                            Genre = "Фентезі",
                            Image = "fc5687f7-1410-42b4-887b-3911a1b11a87.jpeg",
                            Language = "eng",
                            PageCount = 576,
                            Publisher = "КСД",
                            Title = "Володар перснів дві твердині",
                            Year = (short)1954
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Description = "«Воно́» — роман американського письменника Стівена Кінга, написаний у жанрі жахів, уперше опублікований 1986 року видавництвом Viking Press. У творі зачіпаються важливі для Кінга теми: влада пам'яті, сила в об'єднанні, вплив травм дитинства на доросле життя.",
                            Genre = "Фантастика жахів",
                            Image = "c29f29d8-f54f-4ba0-b11d-f0cd90c811d2.jpeg",
                            Language = "eng",
                            PageCount = 1344,
                            Publisher = "КСД",
                            Title = "Воно",
                            Year = (short)1986
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 3,
                            Description = "«Шукач» — роман американського письменника Стівена Кінга, що розпочинає серію романів про Темну Вежу, яку Кінг презентує як свій Magnum opus. Автор розпочав роботу над романом в 1970 році, а закінчив в 1980. Протягом 1978—1981 рр. роман публікувався окремими повістями в періодиці.",
                            Genre = "Фентезі",
                            Image = "21a02fd7-f503-40e9-b1f1-26b07def8eae.jpeg",
                            Language = "eng",
                            PageCount = 240,
                            Publisher = "КСД",
                            Title = "Темна Вежа I: Стрілець",
                            Year = (short)1982
                        });
                });

            modelBuilder.Entity("Library_NPR321.Models.Book", b =>
                {
                    b.HasOne("Library_NPR321.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Library_NPR321.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
