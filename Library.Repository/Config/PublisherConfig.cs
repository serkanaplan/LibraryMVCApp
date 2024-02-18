using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class PublisherConfig : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
              new Publisher { PublisherId = 1, Name = "İş Bankası" },
              new Publisher { PublisherId = 2, Name = "Eksen" },
              new Publisher { PublisherId = 3, Name = "Sarmal" },
              new Publisher { PublisherId = 4, Name = "Evren" },
              new Publisher { PublisherId = 5, Name = "Kırmızı" },
              new Publisher { PublisherId = 6, Name = "Tutku" },
              new Publisher { PublisherId = 7, Name = "Yapıtaş" },
              new Publisher { PublisherId = 8, Name = "Simya" },
              new Publisher { PublisherId = 9, Name = "Sandal" },
              new Publisher { PublisherId = 10, Name = "Kütük" },
              new Publisher { PublisherId = 11, Name = "Ayçiçeği" },
              new Publisher { PublisherId = 12, Name = "Kızılcık" },
              new Publisher { PublisherId = 13, Name = "KocaÇınar" },
              new Publisher { PublisherId = 14, Name = "Papatya" },
              new Publisher { PublisherId = 15, Name = "Turna" }
          );
        }
    }
}
