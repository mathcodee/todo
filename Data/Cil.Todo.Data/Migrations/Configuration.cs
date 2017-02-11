namespace Cil.Todo.Data.Migrations
{
    using Domain;
    using Enum;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cil.Todo.Data.CilDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cil.Todo.Data.CilDataContext context)
        {
            context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [CTD].[City] ON");

            context.Country.AddOrUpdate(p => p.Code,
                new Country
                {
                    Name = "T�rkiye",
                    Code = "90",
                    DisplayOrder = -100,
                    RowId = Guid.NewGuid(),
                    States = new List<State>()
                    {
                        #region States
                        new State { Name = "Adana", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Ad�yaman", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Afyonkarahisar", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "A�r�", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Amasya", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Ankara", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Antalya", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Artvin", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Ayd�n", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bal�kesir", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bilecik", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bing�l", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bitlis", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bolu", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Burdur", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bursa", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "�anakkale", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "�ank�r�", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "�orum", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Denizli", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Diyarbak�r", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Edirne", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Elaz��", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Erzincan", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Erzurum", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Eski�ehir", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Gaziantep", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Giresun", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "G�m��hane", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Hakk�ri", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Hatay", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Isparta", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "��el(Mersin)", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "�stanbul", DisplayOrder = -100, RowId = Guid.NewGuid(),
                            Cities = new List<City>()
                            {
                                new City { Id= 1, Name = "�i�li", DisplayOrder =100, RowId = Guid.NewGuid() }
                            }
                        },
                        new State { Name = "�zmir", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Kars", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Kastamonu", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Kayseri", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "K�rklareli", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "K�r�ehir", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Kocaeli", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Konya", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "K�tahya", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Malatya", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Manisa", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Kahramanmara�	", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Mardin", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Mu�la", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Mu�", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Nev�ehir", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Ni�de", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Ordu", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Rize", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Sakarya", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Samsun", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Siirt", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Sinop", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Sivas", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Tekirda�", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Tokat", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Trabzon", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Tunceli	",DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "�anl�urfa", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "U�ak", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Van", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Yozgat", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Zonguldak", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Aksaray", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bayburt", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Karaman", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "K�r�kkale", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Batman", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "��rnak", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Bart�n", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Ardahan", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "I�d�r", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Yalova", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Karab�k", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Kilis", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "Osmaniye", DisplayOrder = -100, RowId = Guid.NewGuid() },
                        new State { Name = "D�zce", DisplayOrder = -100, RowId = Guid.NewGuid() }
                        #endregion
                    }
                }
            );


            context.User.AddOrUpdate(p => p.Username,
                new User
                {
                    Name = "Mehmet",
                    LastName = "KURT",
                    GenderId = (int)GenderType.Man,
                    Username = "codeislife",
                    Password = "d7faef65e9ee2e606f7a0e955f6f46a0",
                    PasswordSalt = "s0mRIdlKvI",
                    Email = "team@codeislife.net",
                    IsActive = true,
                    IsApproved = true,
                    CityId = 1,
                    RowId = Guid.NewGuid()
                }
            );

            context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [CTD].[City] OFF");
        }
    }
}
