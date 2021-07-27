using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");
            Property(x => x.CustomerFirstname).HasMaxLength(255).IsRequired();
            Property(x => x.CustomerSurname).HasMaxLength(255).IsRequired();
            Property(x => x.CustomerEmail).HasMaxLength(255).IsRequired();
            Property(x => x.CustomerPhone).HasMaxLength(32).IsOptional();
            Property(x => x.PaymentTypeName).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentProviderCode).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentProviderName).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentGatewayCode).HasMaxLength(128).IsRequired();
            Property(x => x.PaymentGatewayName).HasMaxLength(128).IsRequired();
            Property(x => x.BankName).HasMaxLength(128).IsOptional();
            Property(x => x.ClientIp).HasMaxLength(32).IsRequired();
            Property(x => x.BankName).HasMaxLength(1024).IsOptional();
            Property(x => x.Currency).HasMaxLength(32).IsRequired();
            Property(x => x.CurrencyRates).HasMaxLength(65535).IsRequired();
            Property(x => x.Amount).IsRequired();
            Property(x => x.CouponDiscount).IsRequired();
            Property(x => x.TaxAmount).IsRequired();
            Property(x => x.PromotionDiscount).IsRequired();
            Property(x => x.GeneralAmount).IsRequired();
            Property(x => x.ShippingAmount).IsRequired();
            Property(x => x.AdditionalServiceAmount).IsRequired();
            Property(x => x.FinalAmount).IsRequired();
            Property(x => x.SumOfGainedPoints).IsOptional();
            Property(x => x.Installment).IsOptional();
            Property(x => x.InstallmentRate).IsOptional();
            Property(x => x.ExtraInstallment).IsOptional();
            Property(x => x.TransactionId).IsOptional();
            Property(x => x.HasUserNote).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.PaymentStatus).IsRequired();
            Property(x => x.ErrorMessage).IsOptional();
            Property(x => x.DeviceType).IsRequired();
            Property(x => x.Referrer).HasMaxLength(65535).IsOptional();
            Property(x => x.InvoicePrintCount).IsOptional();
            Property(x => x.UseGiftPackage).IsRequired();
            Property(x => x.GiftNote).HasMaxLength(65535).IsOptional();
            Property(x => x.MemberGroupName).HasMaxLength(255).IsOptional();
            Property(x => x.UsePromotion).IsRequired();
            Property(x => x.ShippingProviderCode).HasMaxLength(128).IsOptional();
            Property(x => x.ShippingProviderName).HasMaxLength(128).IsOptional();
            Property(x => x.ShippingCompanyName).HasMaxLength(128).IsOptional();
            Property(x => x.ShippingPaymentType).IsOptional();
            Property(x => x.ShippingTrackingCode).HasMaxLength(255).IsOptional();
            Property(x => x.Source).HasMaxLength(255).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsRequired();
            Property(x => x.MaillistId).IsOptional();
            Property(x => x.MemberId).IsOptional();
            Property(x => x.ShippingAddressId).IsOptional();
            Property(x => x.BillingAddressId).IsOptional();

        }
    }
}
