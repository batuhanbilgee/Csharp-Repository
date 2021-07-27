using _21_OOP_Hamburgerci.ORM.Entity;
using _21_OOP_Hamburgerci.ORM.Map;
using System.Data.Entity;

namespace _21_OOP_Hamburgerci.ORM.Context
{
    public class DataContext :DbContext
    {
        public DataContext() 
            :base ("Name=Conn")
        {

        }

        public DbSet<ExtraMalzeme> ExtraMalzemes { get; set; }
        public DbSet<Menuler> Menus { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisToExtraMalzeme> siparisToExtras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ExtraMalzemeMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new SiparisMap());
            modelBuilder.Configurations.Add(new SiparisToExtraMalzemeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
