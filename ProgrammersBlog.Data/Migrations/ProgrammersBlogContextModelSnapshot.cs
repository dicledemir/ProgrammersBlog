﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;

namespace ProgrammersBlog.Data.Migrations
{
    [DbContext(typeof(ProgrammersBlogContext))]
    partial class ProgrammersBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreateByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque dictum ultricies dui. Sed semper, est quis molestie venenatis, orci ligula iaculis augue, vel fermentum nunc turpis sed purus. Donec et fermentum leo. Fusce id ligula nibh. Curabitur iaculis est bibendum erat feugiat, eget pharetra urna aliquet. Vivamus vel lectus nec erat rhoncus euismod mattis ut elit. Nulla neque tortor, laoreet non enim vitae, commodo consequat dui. Vestibulum vestibulum convallis fermentum. Vestibulum id molestie quam. Donec vitae luctus justo. Maecenas mattis erat ut tortor euismod sollicitudin. Nunc in lorem ligula. Pellentesque lacinia enim vel magna pulvinar venenatis. Morbi posuere posuere facilisis.\r\n\r\n                Suspendisse vel convallis sem,\r\n                nec tristique felis.Cras aliquam placerat augue,\r\n                quis fringilla lectus.Duis sodales augue sit amet ligula sagittis ultrices.Aenean dignissim lobortis rutrum.Aenean tortor urna,\r\n                volutpat at euismod vitae,\r\n                egestas at odio.Vivamus molestie nisl posuere gravida faucibus.Vivamus aliquam eu ante ac facilisis.Pellentesque efficitur nunc id metus maximus,\r\n                vitae porttitor nunc fringilla.Interdum et malesuada fames ac ante ipsum primis in faucibus.Sed mollis lorem quam,\r\n                et ornare ligula sollicitudin nec.Donec ut lobortis quam.Suspendisse potenti.Phasellus molestie id dolor in pretium.Nam augue libero,\r\n                ullamcorper et nisi a,\r\n                sollicitudin luctus nisi.",
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(533),
                            Date = new DateTime(2020, 12, 9, 15, 3, 53, 194, DateTimeKind.Local).AddTicks(8565),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(1516),
                            Note = "C# 9.0 ve .Net 5 Yenilikleri",
                            SeoAuthor = "Dicle Demir",
                            SeoDescription = "C# 9.0 ve .Net 5 Yenilikleri",
                            SeoTags = "C#, C# 9, .Net5, .Net Framework, .Net Core",
                            Thumbnail = "Default.jpg",
                            Title = "C# 9.0 ve .Net 5 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Ut sit amet blandit nisi. Donec dictum lacinia massa, nec mattis sapien luctus et.\r\nPellentesque faucibus nec magna tristique lobortis. Nunc vitae dolor ut dui sollicitudin hendrerit. Nullam imperdiet \r\nluctus orci id mattis. Pellentesque convallis in lectus efficitur tristique. Donec viverra malesuada orci id feugiat. Cras molestie suscipit interdum.\r\n\r\nNunc ante urna, faucibus aliquet finibus sed, congue a lorem. Morbi vel mattis dolor. Fusce vel tortor semper ligula facilisis mattis sit amet sed elit. Quisque viverra sagittis purus vel bibendum. Phasellus aliquam mattis gravida. Maecenas mi sem, ultrices quis nisl vitae, sollicitudin ornare odio. Duis bibendum elit vel sem pharetra, a aliquam nibh fringilla. Vivamus et orci placerat, aliquet quam quis, porttitor est. Morbi vitae justo eget nisl viverra euismod. Duis tempus turpis iaculis justo vestibulum, non efficitur tortor auctor. Nam odio quam, varius eu vehicula sit amet, porttitor vel orci.",
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3954),
                            Date = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3946),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3954),
                            Note = "Java 9.0 ve java 5 Yenilikleri",
                            SeoAuthor = "Dicle Demir",
                            SeoDescription = "java 9.0 ve java 5 Yenilikleri",
                            SeoTags = "C#, C# 9, .Net5, .Net Framework, .Net Core",
                            Thumbnail = "Default.jpg",
                            Title = "C#, C# 9, .Net5, .Net Framework, .Net Core",
                            UserId = 1,
                            ViewsCount = 18
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Nam at lorem commodo, auctor felis non, faucibus neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel tellus non neque congue venenatis. Sed augue mauris, lobortis nec posuere ac, vehicula sed sapien. Phasellus ac justo nec lectus sodales rhoncus eget at magna. Sed iaculis mauris et varius iaculis. Sed consequat consectetur nunc et elementum. Nullam lobortis ipsum ut pellentesque vestibulum. Vestibulum volutpat libero sollicitudin posuere fermentum. Sed sed ligula dolor. Proin ullamcorper, lectus a eleifend aliquet, massa nulla porta risus, quis aliquam quam ipsum ac lacus. ",
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3993),
                            Date = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3993),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 195, DateTimeKind.Local).AddTicks(3993),
                            Note = "Java 9.0 ve java 5 Yenilikleri",
                            SeoAuthor = "Dicle Demir",
                            SeoDescription = "JavaScript ES2019 ve ES2020 Yenilikleri",
                            SeoTags = "JavaScript ES2019 ve ES2020 Yenilikleri",
                            Thumbnail = "Default.jpg",
                            Title = "JavaScript ES2019 ve ES2020 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 280
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreateByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4862),
                            Description = "C# Programlama Dili ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4882),
                            Name = "C#",
                            Note = "C# Blog Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4941),
                            Description = "Java Programlama Dili ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4945),
                            Name = "Java",
                            Note = "Java Blog Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4949),
                            Description = "JavaScript Programlama Dili ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 199, DateTimeKind.Local).AddTicks(4949),
                            Name = "JavaScript",
                            Note = "JavaScript Blog Kategorisi"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreateByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1300)
                        .HasColumnType("nvarchar(1300)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1793),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1797),
                            Note = "C# makale yorumu",
                            Text = "Nunc ante urna, faucibus aliquet finibus sed, congue a lorem."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1829),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1833),
                            Note = "Java makale yorumu",
                            Text = "Morbi vel mattis dolor. Fusce vel tortor semper ligula."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1833),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 202, DateTimeKind.Local).AddTicks(1837),
                            Note = "JavaScript makale yorumu",
                            Text = "Morbi vel mattis dolor. Fusce vel tortor semper ligula."
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreateByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 204, DateTimeKind.Local).AddTicks(4987),
                            Description = "Admin rolü, tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 204, DateTimeKind.Local).AddTicks(4991),
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreateByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateByName = "InitialCreate",
                            CreateDate = new DateTime(2020, 12, 9, 15, 3, 53, 211, DateTimeKind.Local).AddTicks(9539),
                            Description = "İlk admin kullanıcı",
                            Email = "dmrdicle@gmail.com",
                            FirstName = "Dicle",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Demir",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2020, 12, 9, 15, 3, 53, 211, DateTimeKind.Local).AddTicks(9543),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = " https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            UserName = "dicle.demir"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgrammersBlog.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}