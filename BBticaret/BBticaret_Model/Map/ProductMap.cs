using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(65535).IsOptional();
            Property(x => x.FullName).HasMaxLength(255).IsRequired();
            Property(x => x.Sku).HasMaxLength(255).IsRequired();
            Property(x => x.Barcode).HasMaxLength(255).IsOptional();
            Property(x => x.Price1).IsRequired();
            Property(x => x.Warranty).IsOptional();
            Property(x => x.Tax).IsOptional();
            Property(x => x.StockAmount).IsOptional();
            Property(x => x.VolumetricWeight).IsOptional();
            Property(x => x.BuyingPrice).IsOptional();
            Property(x => x.StockTypeLabel).IsRequired();
            Property(x => x.Discount).IsOptional();
            Property(x => x.DiscountType).IsOptional();
            Property(x => x.MoneyOrderDiscount).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.TaxIncluded).IsRequired();
            Property(x => x.Distributor).HasMaxLength(255).IsOptional();
            Property(x => x.IsGifted).IsOptional();
            Property(x => x.Gift).HasMaxLength(255).IsOptional();
            Property(x => x.CustomShippingDisabled).IsOptional();
            Property(x => x.CustomShippingCost).IsOptional();
            Property(x => x.MarketPriceDetail).HasMaxLength(255).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.MetaKeywords).HasMaxLength(65535).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(65535).IsOptional();
            Property(x => x.PageTitle).HasMaxLength(255).IsOptional();
            Property(x => x.HasOption).IsOptional();
            Property(x => x.ShortDetails).HasMaxLength(512).IsOptional();
            Property(x => x.SearchKeywords).HasMaxLength(255).IsOptional();
            Property(x => x.InstallmentThreshold).HasMaxLength(10).IsOptional();
            Property(x => x.HomeSortOrder).IsOptional();
            Property(x => x.PopularSortOrder).IsOptional();
            Property(x => x.BrandSortOrder).IsOptional();
            Property(x => x.FeaturedSortOrder).IsOptional();
            Property(x => x.CampaignedSortOrder).IsOptional();
            Property(x => x.NewSortOrder).IsOptional();
            Property(x => x.DiscountedSortOrder).IsOptional();
            Property(x => x.BrandId).IsOptional();
            Property(x => x.CurrencyId).IsOptional();
            Property(x => x.ProductId).IsOptional();
            Property(x => x.ProductToCountDownId).IsOptional();


        }
    }
}
