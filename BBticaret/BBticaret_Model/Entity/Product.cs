using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Product:BaseEntity
    {
        //public Product()
        //{
        //    ProductDetails = new HashSet<ProductDetail>();
        //    ProductToCountDowns = new HashSet<ProductToCountDown>();
        //    ProductPrices = new HashSet<ProductPrice>();
        //    ProductToCategories = new HashSet<ProductToCategory>();
        //    SpecToProducts = new HashSet<SpecToProduct>();
        //    ProductImages = new HashSet<ProductImage>();
        //    ProductToTags = new HashSet<ProductToTag>();
        //    ProductButtons = new HashSet<ProductButton>();
        //    ProductComments = new HashSet<ProductComment>();
        //    DistributorToProducts = new HashSet<DistributorToProduct>();
        //    ExtraInfoToProducts = new HashSet<ExtraInfoToProduct>();
        //    SelectionToProducts = new HashSet<SelectionToProduct>();
        //    ProductProtections = new HashSet<ProductProtection>();
        //    FavouritedProducts = new HashSet<FavouritedProduct>();
        //    LabelToProducts = new HashSet<LabelToProduct>();
        //    CombineProducts = new HashSet<CombineProduct>();
        //    ProductSpecialInfos = new HashSet<ProductSpecialInfo>();
        //    PurchaseLimitationItems = new HashSet<PurchaseLimitationItem>();
        //    CartItems = new HashSet<CartItem>();
        //    OrderItems = new HashSet<OrderItem>();
        //    ShipmentItems = new HashSet<ShipmentItem>();
        //}
        public string Name { get; set; }
        public string Slug { get; set; }
        public string FullName { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public float Price1 { get; set; }
        public float Warranty { get; set; }
        public float Tax { get; set; }
        public float StockAmount { get; set; }
        public float VolumetricWeight { get; set; }
        public float BuyingPrice { get; set; }
        public ProductStockTypeLabel StockTypeLabel { get; set; }
        public float Discount { get; set; }
        public bool DiscountType { get; set; }
        public float MoneyOrderDiscount { get; set; }
        public bool Status { get; set; }
        public bool TaxIncluded { get; set; }
        public string Distributor { get; set; }
        public bool IsGifted { get; set; }
        public string Gift { get; set; }
        public bool CustomShippingDisabled { get; set; }
        public float CustomShippingCost { get; set; }
        public string MarketPriceDetail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public bool HasOption { get; set; }
        public string ShortDetails { get; set; }
        public string SearchKeywords { get; set; }
        public string InstallmentThreshold { get; set; }
        public int HomeSortOrder { get; set; }
        public int PopularSortOrder { get; set; }
        public int BrandSortOrder { get; set; }
        public int FeaturedSortOrder { get; set; }
        public int CampaignedSortOrder { get; set; }
        public int NewSortOrder { get; set; }
        public int DiscountedSortOrder { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int ProductId { get; set; }
        public Product ParentProduct { get; set; }
        [ForeignKey("ProductToCountDown")]
        public int ProductToCountDownId { get; set; }
        public ProductToCountDown ProductToCountDown { get; set; }

        //public ICollection<ProductToCountDown> ProductToCountDowns { get; set; }
        //public ICollection<ProductDetail> ProductDetails { get; set; }
        //public ICollection<ProductToCategory> ProductToCategories { get; set; }
        //public ICollection<SpecToProduct> SpecToProducts { get; set; }
        //public ICollection<ProductImage> ProductImages { get; set; }
        //public ICollection<ProductToTag> ProductToTags { get; set; }
        //public ICollection<ProductButton> ProductButtons { get; set; }
        //public ICollection<ProductComment> ProductComments { get; set; }
        //public ICollection<DistributorToProduct> DistributorToProducts { get; set; }
        //public ICollection<ExtraInfoToProduct> ExtraInfoToProducts { get; set; }
        //public ICollection<SelectionToProduct> SelectionToProducts { get; set; }
        //public ICollection<ProductProtection> ProductProtections { get; set; }
        //public ICollection<FavouritedProduct> FavouritedProducts { get; set; }
        //public ICollection<LabelToProduct> LabelToProducts { get; set; }
        //public ICollection<CombineProduct> CombineProducts { get; set; }
        //public ICollection<ProductSpecialInfo> ProductSpecialInfos { get; set; }
        //public ICollection<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
        //public ICollection<CartItem> CartItems { get; set; }
        //public ICollection<OrderItem> OrderItems { get; set; }
        //public ICollection<ShipmentItem> ShipmentItems { get; set; }

    }
}
