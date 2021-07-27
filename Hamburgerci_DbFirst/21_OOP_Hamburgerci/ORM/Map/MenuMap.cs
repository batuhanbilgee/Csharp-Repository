using _21_OOP_Hamburgerci.ORM.Entity;

namespace _21_OOP_Hamburgerci.ORM.Map
{
    public class MenuMap:BaseMap<Menuler>
    {
        public MenuMap()
        {
            ToTable("dbo.Menu");

            Property(x => x.MenuAdi)
                .HasMaxLength(100)
                .HasColumnOrder(2)
                .IsRequired();

            Property(x => x.MenuFiyati)
                .HasColumnOrder(3)
                .IsRequired();
        }
    }
}
