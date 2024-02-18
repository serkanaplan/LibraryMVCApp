using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
              new Language { LanguageId = 1, Name = "Turkce" },
              new Language { LanguageId = 2, Name = "Ingilizce" },
              new Language { LanguageId = 3, Name = "Almanca" },
              new Language { LanguageId = 4, Name = "Rusca" },
              new Language { LanguageId = 5, Name = "Ispanyolca" },
              new Language { LanguageId = 6, Name = "Fransizca" },
              new Language { LanguageId = 7, Name = "Italyanca" },
              new Language { LanguageId = 8, Name = "Arabca" },
              new Language { LanguageId = 9, Name = "Portekizce" },
              new Language { LanguageId = 10, Name = "Japonca" },
              new Language { LanguageId = 11, Name = "Korece" },
              new Language { LanguageId = 12, Name = "Cince" },
              new Language { LanguageId = 13, Name = "Ibranice" },
              new Language { LanguageId = 14, Name = "Bengalce" },
              new Language { LanguageId = 15, Name = "Hintce" }
          );
        }
    }
}
