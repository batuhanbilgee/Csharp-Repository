using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class PreOrderInfo : BaseEntity
    {
        public string SessionId { get; set; }
        public string CustomerFirstname { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string ShippingFirstname { get; set; }
        public string ShippingSurname { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingMobilePhoneNumber { get; set; }
        public string ShippingLocationName { get; set; }
        public string ShippingTown { get; set; }
        public bool DifferentBillingAddress { get; set; }
        public string BillingFirstname { get; set; }
        public string BillingSurname { get; set; }
        public string BillingAddress { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingMobilePhoneNumber { get; set; }
        public string BillingLocationName { get; set; }
        public string BillingTown { get; set; }
        public PreOrderInfoBillingInvoiceType BillingInvoiceType { get; set; }
        public string BillingIdentityRegistrationNumber { get; set; }
        public string BillingTaxOffice { get; set; }
        public string BillingTaxNo { get; set; }
        public bool IsEinvoiceUser { get; set; }
        public bool UseGiftPackage { get; set; }
        public string GiftNote { get; set; }
        public string ImageFile { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Country")]
        public int BillingCountryId { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Location")]
        public int BillingLocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("ShippingCompany")]
        public int ShippingCompanyId { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
        [ForeignKey("ShippingCountry")]
        public int ShippingCountryId { get; set; }
        public Country ShippingCountry { get; set; }
        [ForeignKey("ShippingLocation")]
        public int ShippingLocationId { get; set; }
        public Location ShippingLocation { get; set; }
        [ForeignKey("MemberShippingAddress")]
        public int MemberShippingAddressId { get; set; }
        public ShippingAddress MemberShippingAddress { get; set; }
        [ForeignKey("MemberBillingAddress")]
        public int MemberBillingAddressId { get; set; }
        public BillingAddress MemberBillingAddress { get; set; }





    }
}
