using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Fantastik", Img = "1.jpg" },
                new Category { CategoryId = 2, Name = "Korku", Img = "2.jpeg" },
                new Category { CategoryId = 3, Name = "Romantik", Img = "3.jpeg" },
                new Category { CategoryId = 4, Name = "Bilim", Img = "4.jpeg" },
                new Category { CategoryId = 5, Name = "Edebiyat", Img = "5.jpg" },
                new Category { CategoryId = 6, Name = "Hikaye", Img = "6.jpg" },
                new Category { CategoryId = 7, Name = "Tarih", Img = "7.jpg" },
                new Category { CategoryId = 8, Name = "Cocuk", Img = "8.jpeg" },
                new Category { CategoryId = 9, Name = "Saglik", Img = "9.jpeg" },
                new Category { CategoryId = 10, Name = "Spor", Img = "10.jpg" },
                new Category { CategoryId = 11, Name = "Klasik", Img = "11.jpeg" },
                new Category { CategoryId = 12, Name = "Yabanci", Img = "12.jpg" },
                new Category { CategoryId = 13, Name = "Dil", Img = "13.jpeg" },
                new Category { CategoryId = 14, Name = "Roman", Img = "14.jpeg" },
                new Category { CategoryId = 15, Name = "Anı", Img = "15.jpeg" }
            );
        }
    }
}
