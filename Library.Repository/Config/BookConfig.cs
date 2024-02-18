using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class BookConfig:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Description).HasDefaultValue("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
            builder.Property(p => p.Status).HasDefaultValue(true);
            builder.Property(p => p.Rated).HasDefaultValue(new Random().Next(100,1000));
            builder.Property(p => p.Title).IsRequired();


            builder.HasData(
              new Book { BookId = 1, Title = "Kýrmýzý Geçe", AuthorId = 1, Stock = 5, ShelfId = 1, CategoryId = 1, LanguageId = 1, PublisherId = 1, Img = "1.jpg",PublishedDate = DateTime.Now.Year-new Random().Next(1,100) },
              new Book { BookId = 2, Title = "Suç Ve Ceza", AuthorId = 2, Stock = 5, ShelfId = 2, CategoryId = 2, LanguageId = 2, PublisherId = 2, Img = "2.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 3, Title = "Yaþama Sevinci", AuthorId = 3, Stock = 5, ShelfId = 3, CategoryId = 3, LanguageId = 3, PublisherId = 3, Img = "3.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 4, Title = "1984", AuthorId = 4, Stock = 5, ShelfId = 4, CategoryId = 4, LanguageId = 4, PublisherId = 4, Img = "4.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 5, Title = "Prometheus", AuthorId = 5, Stock = 5, ShelfId = 5, CategoryId = 5, LanguageId = 5, PublisherId = 5, Img = "5.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 6, Title = "Sinekli Bakkal", AuthorId = 6, Stock = 5, ShelfId = 6, CategoryId = 6, LanguageId = 6, PublisherId = 6, Img = "6.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 7, Title = "Avrupa Ve Biz", AuthorId = 7, Stock = 5, ShelfId = 7, CategoryId = 7, LanguageId = 7, PublisherId = 7, Img = "7.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 8, Title = "Devlet Ve Hukuk", AuthorId = 8, Stock = 5, ShelfId = 8, CategoryId = 8, LanguageId = 8, PublisherId = 8, Img = "8.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 9, Title = "Anna Karenina", AuthorId = 9, Stock = 5, ShelfId = 9, CategoryId = 9, LanguageId = 9, PublisherId = 9, Img = "9.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 10, Title = "Arkadaþ", AuthorId = 10, Stock = 5, ShelfId = 10, CategoryId = 10, LanguageId = 10, PublisherId = 10, Img = "10.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 11, Title = "Kan Konuþmaz", AuthorId = 11, Stock = 5, ShelfId = 11, CategoryId = 11, LanguageId = 11, PublisherId = 11, Img = "11.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 12, Title = "Ruhun Tutkularý", AuthorId = 12, Stock = 5, ShelfId = 12, CategoryId = 12, LanguageId = 12, PublisherId = 12, Img = "12.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 13, Title = "Ýçimizdeki Þeytan", AuthorId = 13, Stock = 5, ShelfId = 13, CategoryId = 13, LanguageId = 13, PublisherId = 13, Img = "13.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 14, Title = "Kitle Psikolojisi", AuthorId = 14, Stock = 5, ShelfId = 14, CategoryId = 14, LanguageId = 14, PublisherId = 14, Img = "14.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) },
              new Book { BookId = 15, Title = "Satranç", AuthorId = 15, Stock = 5, ShelfId = 15, CategoryId = 15, LanguageId = 15, PublisherId = 15, Img = "15.jpg", PublishedDate = DateTime.Now.Year - new Random().Next(1, 100) }
             );
        }
    }
}