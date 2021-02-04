using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a  => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired(true);
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreateByName).IsRequired();
            builder.Property(a => a.CreateByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreateByName).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c=>c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            builder.HasData(new Article
            {
                Id = 1,
                CategoryId = 1,
                Title = "C# 9.0 ve .Net 5 Yenilikleri",
                Content = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque dictum ultricies dui. Sed semper, est quis molestie venenatis, orci ligula iaculis augue, vel fermentum nunc turpis sed purus. Donec et fermentum leo. Fusce id ligula nibh. Curabitur iaculis est bibendum erat feugiat, eget pharetra urna aliquet. Vivamus vel lectus nec erat rhoncus euismod mattis ut elit. Nulla neque tortor, laoreet non enim vitae, commodo consequat dui. Vestibulum vestibulum convallis fermentum. Vestibulum id molestie quam. Donec vitae luctus justo. Maecenas mattis erat ut tortor euismod sollicitudin. Nunc in lorem ligula. Pellentesque lacinia enim vel magna pulvinar venenatis. Morbi posuere posuere facilisis.

                Suspendisse vel convallis sem,
                nec tristique felis.Cras aliquam placerat augue,
                quis fringilla lectus.Duis sodales augue sit amet ligula sagittis ultrices.Aenean dignissim lobortis rutrum.Aenean tortor urna,
                volutpat at euismod vitae,
                egestas at odio.Vivamus molestie nisl posuere gravida faucibus.Vivamus aliquam eu ante ac facilisis.Pellentesque efficitur nunc id metus maximus,
                vitae porttitor nunc fringilla.Interdum et malesuada fames ac ante ipsum primis in faucibus.Sed mollis lorem quam,
                et ornare ligula sollicitudin nec.Donec ut lobortis quam.Suspendisse potenti.Phasellus molestie id dolor in pretium.Nam augue libero,
                ullamcorper et nisi a,
                sollicitudin luctus nisi.",
                Thumbnail="Default.jpg",
                SeoDescription="C# 9.0 ve .Net 5 Yenilikleri",
                SeoTags="C#, C# 9, .Net5, .Net Framework, .Net Core",
                SeoAuthor="Dicle Demir",
                Date=DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreateByName = "InitialCreate",
                CreateDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# 9.0 ve .Net 5 Yenilikleri",
                UserId=1,
                ViewsCount=100,
                CommentCount=1

            },
            new Article
            {

                Id = 2,
                CategoryId = 2,
                Title = "C#, C# 9, .Net5, .Net Framework, .Net Core",
                Content = @"Ut sit amet blandit nisi. Donec dictum lacinia massa, nec mattis sapien luctus et.
Pellentesque faucibus nec magna tristique lobortis. Nunc vitae dolor ut dui sollicitudin hendrerit. Nullam imperdiet 
luctus orci id mattis. Pellentesque convallis in lectus efficitur tristique. Donec viverra malesuada orci id feugiat. Cras molestie suscipit interdum.

Nunc ante urna, faucibus aliquet finibus sed, congue a lorem. Morbi vel mattis dolor. Fusce vel tortor semper ligula facilisis mattis sit amet sed elit. Quisque viverra sagittis purus vel bibendum. Phasellus aliquam mattis gravida. Maecenas mi sem, ultrices quis nisl vitae, sollicitudin ornare odio. Duis bibendum elit vel sem pharetra, a aliquam nibh fringilla. Vivamus et orci placerat, aliquet quam quis, porttitor est. Morbi vitae justo eget nisl viverra euismod. Duis tempus turpis iaculis justo vestibulum, non efficitur tortor auctor. Nam odio quam, varius eu vehicula sit amet, porttitor vel orci.",
                Thumbnail = "Default.jpg",
                SeoDescription = "java 9.0 ve java 5 Yenilikleri",
                SeoTags = "C#, C# 9, .Net5, .Net Framework, .Net Core",
                SeoAuthor = "Dicle Demir",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreateByName = "InitialCreate",
                CreateDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Java 9.0 ve java 5 Yenilikleri",
                UserId = 1,
                ViewsCount = 18,
                CommentCount = 1
            },
             new Article
             {

                 Id = 3,
                 CategoryId = 3,
                 Title = "JavaScript ES2019 ve ES2020 Yenilikleri",
                 Content = @"Nam at lorem commodo, auctor felis non, faucibus neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vel tellus non neque congue venenatis. Sed augue mauris, lobortis nec posuere ac, vehicula sed sapien. Phasellus ac justo nec lectus sodales rhoncus eget at magna. Sed iaculis mauris et varius iaculis. Sed consequat consectetur nunc et elementum. Nullam lobortis ipsum ut pellentesque vestibulum. Vestibulum volutpat libero sollicitudin posuere fermentum. Sed sed ligula dolor. Proin ullamcorper, lectus a eleifend aliquet, massa nulla porta risus, quis aliquam quam ipsum ac lacus. ",
                 Thumbnail = "Default.jpg",
                 SeoDescription = "JavaScript ES2019 ve ES2020 Yenilikleri",
                 SeoTags = "JavaScript ES2019 ve ES2020 Yenilikleri",
                 SeoAuthor = "Dicle Demir",
                 Date = DateTime.Now,
                 IsActive = true,
                 IsDeleted = false,
                 CreateByName = "InitialCreate",
                 CreateDate = DateTime.Now,
                 ModifiedByName = "InitialCreate",
                 ModifiedDate = DateTime.Now,
                 Note = "Java 9.0 ve java 5 Yenilikleri",
                 UserId = 1,
                 ViewsCount = 280,
                 CommentCount = 1
             }



            );

        }
    }
}
