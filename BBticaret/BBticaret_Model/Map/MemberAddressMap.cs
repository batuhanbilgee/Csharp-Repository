using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class MemberAddressMap:BaseMap<MemberAddress>
    {
        public MemberAddressMap()
        {
            ToTable("dbo.MemberAddresses");
            Property(x => x.Name).HasMaxLength(255).IsOptional();
            Property(x => x.Type).IsOptional();
            Property(x => x.FirstName).HasMaxLength(255).IsOptional();
            Property(x => x.SurName).HasMaxLength(255).IsOptional();
            Property(x => x.Address).HasMaxLength(65535).IsOptional();
            Property(x => x.SubLocationName).HasMaxLength(255).IsOptional();
            Property(x => x.PhoneNumber).HasMaxLength(32).IsOptional();
            Property(x => x.MobilePhoneNumber).HasMaxLength(32).IsOptional();
            Property(x => x.TCLD).HasMaxLength(55).IsOptional();
            Property(x => x.TaxNumber).HasMaxLength(255).IsOptional();
            Property(x => x.TaxOffice).HasMaxLength(255).IsOptional();
            Property(x => x.InvoiceType).IsOptional();
            Property(x => x.IsEinvoiceUser).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.MemberId).IsOptional();
            Property(x => x.CountryId).IsOptional();
            Property(x => x.LocationId).IsOptional();
            Property(x => x.SubLocationId).IsOptional();
        }
    }
}
