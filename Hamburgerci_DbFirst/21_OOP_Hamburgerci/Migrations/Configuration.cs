namespace _21_OOP_Hamburgerci.Migrations
{
    using _21_OOP_Hamburgerci.ORM.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_21_OOP_Hamburgerci.ORM.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_21_OOP_Hamburgerci.ORM.Context.DataContext context)
        {
            context.Menus.AddOrUpdate(x => x.Id, new Menuler
            {
                MenuAdi = "WhopperBurger",
                MenuFiyati = 18,
            });   
            context.Menus.AddOrUpdate(x => x.Id, new Menuler
            {
                MenuAdi = "BigKingBurger",
                MenuFiyati = 28,
            });  
            context.Menus.AddOrUpdate(x => x.Id, new Menuler
            {
                MenuAdi = "ChickenBurger",
                MenuFiyati = 17,
            });  
            context.Menus.AddOrUpdate(x => x.Id, new Menuler
            {
                MenuAdi = "SteakBurger",
                MenuFiyati = 18,
            });   
            context.Menus.AddOrUpdate(x => x.Id, new Menuler
            {
                MenuAdi = "BatBurger ",
                MenuFiyati = 18,
            });

            context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "Ketçap",
                EkstraMalzemeFiyati = 1
            });
            context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "Mayonez",
                EkstraMalzemeFiyati = 1
            }); context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "BBQ",
                EkstraMalzemeFiyati = 2
            }); context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "RanchSos",
                EkstraMalzemeFiyati = 2
            });
            context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "Hardal",
                EkstraMalzemeFiyati = 2
            });

            context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "AcıSos",
                EkstraMalzemeFiyati = 3
            }); 
            context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "Ballı Hardal",
                EkstraMalzemeFiyati = 3
            });
            context.ExtraMalzemes.AddOrUpdate(x => x.Id, new ExtraMalzeme
            {
                EkstraMalzemeAdi = "Körili Mayonez",
                EkstraMalzemeFiyati = 2
            });


        }
    }
}
