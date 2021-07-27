using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Payment:BaseEntity
    {
        public string MemberFirstName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPhone { get; set; }
        public string PaymentTypeName { get; set; }
        public string PaymentProviderCode { get; set; }
        public string PaymentProviderName { get; set; }
        public string PaymentGatewayName { get; set; }
        public string PaymentGatewayCode { get; set; }
        public string BankName { get; set; }
        public PaymentDeviceType DeviceType { get; set; }
        public string ClientIp { get; set; }
        public string CurrencyRates { get; set; }
        public float Amount { get; set; }
        public float FinalAmount { get; set; }
        public float SumOfGainedPoints { get; set; }
        public int Installment { get; set; }
        public float InstallmentRate { get; set; }
        public int ExtraInstallment { get; set; }
        public string Currency { get; set; }
        public string TransactionId { get; set; }
        public string MemberNote { get; set; }
        public string UserNote { get; set; }
        public PaymentStatus Status { get; set; }
        public string ErrorMessage { get; set; }
        public string CardSavingSystem { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int ErrorId { get; set; }
        public Error Error { get; set; }

    }
}
