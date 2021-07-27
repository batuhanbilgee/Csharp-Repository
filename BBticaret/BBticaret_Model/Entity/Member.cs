using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Member:BaseEntity
    {
        //public Member()
        //{
        //    CurrentAccounts = new HashSet<CurrentAccount>();
        //    Payments = new HashSet<Payment>();
        //    Carts = new HashSet<Cart>();
        //    ProductComments = new HashSet<ProductComment>();
        //    MemberAddresses = new HashSet<MemberAddress>();
        //    FavouritedProducts = new HashSet<FavouritedProduct>();
        //    Orders = new HashSet<Order>();
        //    OrderRefundRequests = new HashSet<OrderRefundRequest>();
        //}
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string OtherLocation { get; set; }
        public string Address { get; set; }
        public string TaxNumber { get; set; }
        public string TCLD { get; set; }
        public MemberStatus Status { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ZipCode { get; set; }
        public string CommercialName { get; set; }
        public string TaxOffice { get; set; }
        public DateTime LastMailSentDate { get; set; }
        public string LastIp { get; set; }
        public int GainedPointAmount { get; set; }
        public int SpentPointAmount { get; set; }
        public bool AllowedToCampaigns { get; set; }
        public DateTime AllowedToCampaignsUpdatedAt { get; set; }
        public int ReferredMemberGainedPointAmount { get; set; }
        public string District { get; set; }
        public string DeviceType { get; set; }
        public string DeviceInfo { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("MemberGroup")]
        public int MemberGroupId { get; set; }
        public MemberGroup MemberGroup { get; set; }
        public int ReferredMemberId { get; set; }
        public Member ParentMember { get; set; }
        public bool KvkkStatus { get; set; }
        public DateTime KvkkConfirmationDate { get; set; }
        //public ICollection<CurrentAccount> CurrentAccounts { get; set; }
        //public ICollection<Payment> Payments { get; set; }
        //public ICollection<Cart> Carts { get; set; }
        //public ICollection<ProductComment> ProductComments { get; set; }
        //public ICollection<MemberAddress> MemberAddresses { get; set; }
        //public ICollection<FavouritedProduct> FavouritedProducts { get; set; }
        //public ICollection<Order> Orders { get; set; }
        //public ICollection<OrderRefundRequest> OrderRefundRequests { get; set; }


    }
}
