using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
               new Country { CountryId = 1, Name = "Turkey", Img = "1.png" },
               new Country { CountryId = 2, Name = "Germany", Img = "2.jpg" },
               new Country { CountryId = 3, Name = "England", Img = "3.jpg" },
               new Country { CountryId = 4, Name = "France", Img = "4.jpg" },
               new Country { CountryId = 5, Name = "Italy", Img = "5.jpg" },
               new Country { CountryId = 6, Name = "Spain", Img = "6.jpg" },
               new Country { CountryId = 7, Name = "Portugal", Img = "7.jpg" },
               new Country { CountryId = 8, Name = "Brazil", Img = "8.jpg" },
               new Country { CountryId = 9, Name = "Russia", Img = "9.jpg" },
               new Country { CountryId = 10, Name = "Canada", Img = "10.jpg" },
               new Country { CountryId = 11, Name = "Australia", Img = "11.jpg" },
               new Country { CountryId = 12, Name = "China", Img = "12.jpg" },
               new Country { CountryId = 13, Name = "Japan", Img = "13.jpg" },
               new Country { CountryId = 14, Name = "India", Img = "14.jpg" },
               new Country { CountryId = 15, Name = "Romania", Img = "15.jpg" }
           );
        }
    }
}
