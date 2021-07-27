using BBticaret_Model.Entity;
using BBticaret_Model.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_DAL.Context
{
    public class DataContext:DbContext
    {
        public DataContext()
            :base ("Name=Conn")
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<ExtraInfo> ExtraInfos { get; set; }
        public DbSet<SelectionGroup> SelectionGroups { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<ShopToken> ShopTokens { get; set; }
        public DbSet<QuickCart> QuickCarts { get; set; }
        public DbSet<TownGroup> TownGroups { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<MaillistGroup> MaillistGroups { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<PaymentProviderSetting> PaymentProviderSettings { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<ShopCampaigns> ShopCampaigns { get; set; }
        public DbSet<PurchaseLimitation> PurchaseLimitations { get; set; }
        public DbSet<ScriptTag> ScriptTags { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<OrderItemSubscription> OrderItemSubscriptions { get; set; }
        public DbSet<OrderItemCustomization> OrderItemCustomizations { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<SpecGroup> SpecGroups { get; set; }
        public DbSet<SpecName> SpecNames { get; set; }
        public DbSet<SpecValue> SpecValues { get; set; }
        public DbSet<MemberGroup> MemberGroups { get; set; }
        public DbSet<OptionGroup> OptionGroups { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<ShopUserlevel> ShopUserlevels { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<CurrentAccount> CurrentAccounts { get; set; }
        public DbSet<Selection> Selections { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Maillist> Maillists { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentProvider> PaymentProviders { get; set; }
        public DbSet<PaymentGateway> PaymentGateways { get; set; }
        public DbSet<PaymentGatewaySetting> PaymentGatewaySettings { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<InstallmentRate> InstallmentRates { get; set; }
        public DbSet<ShippingProvider> ShippingProviders { get; set; }
        public DbSet<ShippingProviderSetting> ShippingProviderSettings { get; set; }
        public DbSet<ProductToCountDown> ProductToCountDowns { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductToCategory> ProductToCategories { get; set; }
        public DbSet<SpecToProduct> SpecToProducts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductToTag> ProductToTags { get; set; }
        public DbSet<ProductButton> ProductButtons { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<MemberAddress> MemberAddresses { get; set; }
        public DbSet<OptionToProduct> OptionToProducts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DistributorToProduct> DistributorToProducts { get; set; }
        public DbSet<ExtraInfoToProduct> ExtraInfoToProducts { get; set; }
        public DbSet<SelectionToProduct> SelectionToProducts { get; set; }
        public DbSet<ProductProtection> ProductProtections { get; set; }
        public DbSet<FavouritedProduct> FavouritedProducts { get; set; }
        public DbSet<ShippingCompany> ShippingCompanies { get; set; }
        public DbSet<ShippingRate> ShippingRates { get; set; }
        public DbSet<LabelToProduct> LabelToProducts { get; set; }
        public DbSet<CombineProduct> CombineProducts { get; set; }
        public DbSet<ProductSpecialInfo> ProductSpecialInfos { get; set; }
        public DbSet<PurchaseLimitationItem> PurchaseLimitationItems { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }
        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderRefundRequest> OrderRefundRequests { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderRefundRequestItem> OrderRefundRequestItems { get; set; }
        public DbSet<PreOrderInfo> PreOrderInfos { get; set; }
        public DbSet<OrderUserNote> OrderUserNotes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new DistributorMap());
            modelBuilder.Configurations.Add(new ExtraInfoMap());
            modelBuilder.Configurations.Add(new SelectionGroupMap());
            modelBuilder.Configurations.Add(new ErrorMap());
            modelBuilder.Configurations.Add(new ShopTokenMap());
            modelBuilder.Configurations.Add(new QuickCartMap());
            modelBuilder.Configurations.Add(new TownGroupMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new LabelMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new MaillistGroupMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new PaymentProviderSettingMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new ShopCampaignsMap());
            modelBuilder.Configurations.Add(new PurchaseLimitationMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new OrderItemSubscriptionMap());
            modelBuilder.Configurations.Add(new OrderItemCustomizationMap());
            modelBuilder.Configurations.Add(new PreferenceMap());
            modelBuilder.Configurations.Add(new ThemeMap());
            modelBuilder.Configurations.Add(new AssetMap());
            modelBuilder.Configurations.Add(new SpecGroupMap());
            modelBuilder.Configurations.Add(new SpecNameMap());
            modelBuilder.Configurations.Add(new SpecValueMap());
            modelBuilder.Configurations.Add(new MemberGroupMap());
            modelBuilder.Configurations.Add(new OptionGroupMap());
            modelBuilder.Configurations.Add(new OptionMap());
            modelBuilder.Configurations.Add(new ShopUserlevelMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new CurrentAccountMap());
            modelBuilder.Configurations.Add(new SelectionMap());
            modelBuilder.Configurations.Add(new TownMap());
            modelBuilder.Configurations.Add(new MaillistMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new PaymentProviderMap());
            modelBuilder.Configurations.Add(new PaymentGatewayMap());
            modelBuilder.Configurations.Add(new PaymentGatewaySettingMap());
            modelBuilder.Configurations.Add(new CartMap());
            modelBuilder.Configurations.Add(new InstallmentRateMap());
            modelBuilder.Configurations.Add(new ShippingProviderMap());
            modelBuilder.Configurations.Add(new ShippingProviderSettingMap());
            modelBuilder.Configurations.Add(new ProductToCountDownMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Entity<ProductToCountDown>()
                .HasOptional(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);
            modelBuilder.Configurations.Add(new ProductDetailMap());
            modelBuilder.Configurations.Add(new ProductPriceMap());
            modelBuilder.Configurations.Add(new ProductToCategoryMap());
            modelBuilder.Configurations.Add(new SpecToProductMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
            modelBuilder.Configurations.Add(new ProductToTagMap());
            modelBuilder.Configurations.Add(new ProductButtonMap());
            modelBuilder.Configurations.Add(new ProductCommentMap());
            modelBuilder.Configurations.Add(new MemberAddressMap());
            modelBuilder.Configurations.Add(new OptionToProductMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new DistributorToProductMap());
            modelBuilder.Configurations.Add(new ExtraInfoToProductMap());
            modelBuilder.Configurations.Add(new SelectionToProductMap());
            modelBuilder.Configurations.Add(new ProductProtectionMap());
            modelBuilder.Configurations.Add(new FavouritedProductMap());
            modelBuilder.Configurations.Add(new ShippingCompanyMap());
            modelBuilder.Configurations.Add(new ShippingRateMap());
            modelBuilder.Configurations.Add(new LabelToProductMap());
            modelBuilder.Configurations.Add(new CombineProductMap());
            modelBuilder.Configurations.Add(new ProductSpecialInfoMap());
            modelBuilder.Configurations.Add(new PurchaseLimitationItemMap());
            modelBuilder.Configurations.Add(new CartItemMap());
            modelBuilder.Configurations.Add(new OrderAddressMap());
            modelBuilder.Configurations.Add(new BillingAddressMap());
            modelBuilder.Configurations.Add(new ShippingAddressMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Entity<OrderAddress>()
               .HasOptional(x => x.Order)
               .WithMany()
               .HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<ShippingAddress>()
               .HasOptional(x => x.Order)
               .WithMany()
               .HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<BillingAddress>()
              .HasOptional(x => x.Order)
              .WithMany()
              .HasForeignKey(x => x.OrderId);
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderRefundRequestMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
            modelBuilder.Configurations.Add(new OrderRefundRequestItemMap());
            modelBuilder.Configurations.Add(new PreOrderInfoMap());
            modelBuilder.Configurations.Add(new OrderUserNoteMap());
            modelBuilder.Configurations.Add(new ShipmentMap());
            modelBuilder.Configurations.Add(new ShipmentItemMap());
            modelBuilder.Entity<Theme>()
             .HasOptional(x => x.Asset)
             .WithMany()
             .HasForeignKey(x => x.AssetId);
            modelBuilder.Entity<QuickCart>()
             .HasOptional(x => x.Cart)
             .WithMany()
             .HasForeignKey(x => x.CartId);
            modelBuilder.Entity<Distributor>()
             .HasOptional(x => x.Preference)
             .WithMany()
             .HasForeignKey(x => x.PreferanceId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
