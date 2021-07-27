using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PreOrderInfoMap:BaseMap<PreOrderInfo>
    {
        public PreOrderInfoMap()
        {
            ToTable("dbo.PreOrderInfos");
            Property(x => x.SessionId).HasMaxLength(255).IsRequired();
            Property(x => x.CustomerFirstname).HasMaxLength(255).IsOptional();
            Property(x => x.CustomerSurname).HasMaxLength(255).IsOptional();
            Property(x => x.CustomerEmail).HasMaxLength(255).IsOptional();
            Property(x => x.ShippingFirstname).HasMaxLength(255).IsRequired();
            Property(x => x.ShippingSurname).HasMaxLength(255).IsRequired();
            Property(x => x.ShippingAddress).HasMaxLength(65535).IsRequired();
            Property(x => x.ShippingPhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.ShippingMobilePhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.ShippingLocationName).HasMaxLength(128).IsRequired();
            Property(x => x.ShippingTown).HasMaxLength(128).IsRequired();
            Property(x => x.DifferentBillingAddress).IsOptional();
            Property(x => x.BillingFirstname).HasMaxLength(255).IsRequired();
            Property(x => x.BillingSurname).HasMaxLength(255).IsRequired();
            Property(x => x.BillingAddress).HasMaxLength(65535).IsRequired();
            Property(x => x.BillingPhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.BillingMobilePhoneNumber).HasMaxLength(32).IsRequired();
            Property(x => x.BillingLocationName).HasMaxLength(128).IsRequired();
            Property(x => x.BillingTown).HasMaxLength(128).IsRequired();
            Property(x => x.BillingInvoiceType).IsRequired();
            Property(x => x.BillingIdentityRegistrationNumber).HasMaxLength(32).IsOptional();
            Property(x => x.BillingTaxOffice).HasMaxLength(255).IsOptional();
            Property(x => x.BillingTaxNo).HasMaxLength(128).IsOptional();
            Property(x => x.IsEinvoiceUser).IsOptional();
            Property(x => x.UseGiftPackage).IsOptional();
            Property(x => x.GiftNote).HasMaxLength(65535).IsOptional();
            Property(x => x.ImageFile).HasMaxLength(128).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.BillingCountryId).IsOptional();
            Property(x => x.BillingLocationId).IsOptional();
            Property(x => x.ShippingCompanyId).IsOptional();
            Property(x => x.ShippingCountryId).IsOptional();
            Property(x => x.ShippingLocationId).IsOptional();
            Property(x => x.MemberShippingAddressId).IsOptional();
            Property(x => x.MemberBillingAddressId).IsOptional();
        }
    }
}
