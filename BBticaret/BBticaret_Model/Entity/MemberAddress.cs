using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class MemberAddress:BaseEntity
    {
        public string Name { get; set; }
        public MemberAddressType Type { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string SubLocationName { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string TCLD { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public MemberAddressInvoiceType InvoiceType { get; set; }
        public bool IsEinvoiceUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Town")]
        public int SubLocationId { get; set; }
        public Town Town { get; set; }



    }
}
