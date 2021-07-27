using _21_OOP_Hamburgerci.ORM.Entity;

namespace _21_OOP_Hamburgerci.ORM.Map
{
    public class SiparisMap:BaseMap<Siparis>
    {
        public SiparisMap()
        {
            ToTable("dbo.Siparis");

            Property(x => x.MenuId)
                .HasColumnOrder(2)
                .IsRequired();

            Property(x => x.Boyutu)
               .HasColumnOrder(4)
               .IsRequired();

            Property(x => x.UrunAdeti)
               .HasColumnOrder(5)
               .IsRequired();


            Property(x => x.ToplamTutar)
               .HasColumnOrder(6)
               .IsRequired();
        }
    }
}
