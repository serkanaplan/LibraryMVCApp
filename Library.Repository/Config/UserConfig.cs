using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
           new User { UserId = 1, Tin = "1234", Name = "Serkan", Surname = "Kaplan", Gender = true, Email = "serkan@gmail.com", Password = "123", Age = 20, Role = true, Img = "1.jpeg", },
           new User { UserId = 2, Tin = "1456", Name = "Merve", Surname = "kara", Gender = false, Email = "merve@gmail.com", Password = "123", Age = 51, Role = false, Img = "2.jpeg", },
           new User { UserId = 3, Tin = "1234", Name = "Sadýk", Surname = "þimþek", Gender = true, Email = "sadýk@gmail.com", Password = "123", Age = 45, Role = false, Img = "3.jpeg", },
           new User { UserId = 4, Tin = "4165", Name = "Sarp", Surname = "Sarý", Gender = true, Email = "sarp@gmail.com", Password = "123", Age = 22, Role = false, Img = "4.jpeg", },
           new User { UserId = 5, Tin = "1234", Name = "Sedef", Surname = "Karaca", Gender = false, Email = "sedef@gmail.com", Password = "123", Age = 24, Role = false, Img = "5.jpeg", },
           new User { UserId = 6, Tin = "1234", Name = "sibel", Surname = "Karaca", Gender = false, Email = "sibel@gmail.com", Password = "123", Age = 17, Role = false, Img = "6.jpeg", },
           new User { UserId = 7, Tin = "1234", Name = "Suzan", Surname = "Karaca", Gender = false, Email = "Suzan@gmail.com", Password = "123", Age = 29, Role = false, Img = "7.jpeg", },
           new User { UserId = 8, Tin = "1234", Name = "Mehmet", Surname = "Aker", Gender = true, Email = "mehmet@gmail.com", Password = "123", Age = 29, Role = false, Img = "8.jpeg", }
          );
        }
    }
}