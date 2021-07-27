using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Order:BaseEntity
    {
        //public Order()
        //{
        //    OrderAddresses = new HashSet<OrderAddress>();
        //    ShippingAddresses = new HashSet<ShippingAddress>();
        //    BillingAddresses = new HashSet<BillingAddress>();
        //    OrderDetails = new HashSet<OrderDetail>();
        //    OrderRefundRequests = new HashSet<OrderRefundRequest>();
        //    OrderItems = new HashSet<OrderItem>();
        //    OrderUserNotes = new HashSet<OrderUserNote>();
        //    Shipments = new HashSet<Shipment>();
        //}
        public string CustomerFirstname { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string PaymentTypeName { get; set; }
        public string PaymentProviderCode { get; set; }
        public string PaymentProviderName { get; set; }
        public string PaymentGatewayCode { get; set; }
        public string PaymentGatewayName { get; set; }
        public string BankName { get; set; }
        public string ClientIp { get; set; }
        public string UserAgent { get; set; }
        public string Currency { get; set; }
        public string CurrencyRates { get; set; }
        public float Amount { get; set; }
        public float CouponDiscount { get; set; }
        public float TaxAmount { get; set; }
        public float PromotionDiscount { get; set; }
        public float GeneralAmount { get; set; }
        public float ShippingAmount { get; set; }
        public float AdditionalServiceAmount { get; set; }
        public float FinalAmount { get; set; }
        public float SumOfGainedPoints { get; set; }
        public float Installment { get; set; }
        public float InstallmentRate { get; set; }
        public float ExtraInstallment { get; set; }
        public string TransactionId { get; set; }
        public bool HasUserNote { get; set; }
        public OrderStatus Status { get; set; }
        public OrderPaymentStatus PaymentStatus { get; set; }
        public string ErrorMessage { get; set; }
        public OrderDeviceType DeviceType { get; set; }
        public string Referrer { get; set; }
        public float InvoicePrintCount { get; set; }
        public bool UseGiftPackage { get; set; }
        public string GiftNote { get; set; }
        public string MemberGroupName { get; set; }
        public bool UsePromotion { get; set; }
        public string ShippingProviderCode { get; set; }
        public string ShippingProviderName { get; set; }
        public string ShippingCompanyName { get; set; }
        public OrderShippingPaymentType ShippingPaymentType { get; set; }
        public string ShippingTrackingCode { get; set; }
        public string Source { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Maillist")]
        public int MaillistId { get; set; }
        public Maillist Maillist { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        [ForeignKey("ShippingAddress")]
        public int ShippingAddressId { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        [ForeignKey("BillingAddress")]
        public int BillingAddressId { get; set; }
        public BillingAddress BillingAddress { get; set; }
        //public ICollection<OrderAddress> OrderAddresses { get; set; }
        //public ICollection<ShippingAddress> ShippingAddresses { get; set; }
        //public ICollection<BillingAddress> BillingAddresses { get; set; }
        //public ICollection<OrderDetail> OrderDetails { get; set; }
        //public ICollection<OrderRefundRequest> OrderRefundRequests { get; set; }
        //public ICollection<OrderItem> OrderItems { get; set; }
        //public ICollection<OrderUserNote> OrderUserNotes { get; set; }
        //public ICollection<Shipment> Shipments { get; set; }


    }
}
