using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
  public  class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1300);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreateByName).IsRequired();
            builder.Property(c => c.CreateByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreateByName).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");

            builder.HasData(
                new Comment
            {
                Id = 1,
                ArticleId=1,
                Text= "Nunc ante urna, faucibus aliquet finibus sed, congue a lorem.",
                IsActive = true,
                IsDeleted = false,
                CreateByName = "InitialCreate",
                CreateDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# makale yorumu"
            },
                new Comment
                {
                    Id = 2,
                    ArticleId = 2,
                    Text = "Morbi vel mattis dolor. Fusce vel tortor semper ligula.",
                    IsActive = true,
                    IsDeleted = false,
                    CreateByName = "InitialCreate",
                    CreateDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Java makale yorumu"
                },
                 new Comment
                 {
                     Id = 3,
                     ArticleId = 3,
                     Text = "Morbi vel mattis dolor. Fusce vel tortor semper ligula.",
                     IsActive = true,
                     IsDeleted = false,
                     CreateByName = "InitialCreate",
                     CreateDate = DateTime.Now,
                     ModifiedByName = "InitialCreate",
                     ModifiedDate = DateTime.Now,
                     Note = "JavaScript makale yorumu"
                 }



            );

        }
    }
}
