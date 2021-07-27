using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OrderItemCustomization:BaseEntity
    {
        //public OrderItemCustomization()
        //{
        //    OrderItemSubscriptions = new HashSet<OrderItemSubscription>();
        //}

        public int ProductCustomizationGroupId { get; set; }
        public string ProductCustomizationGroupName { get; set; }
        public int ProductCustomizationGroupSortOrder { get; set; }
        public int ProductCustomizationFieldId { get; set; }
        public string ProductCustomizationFieldType { get; set; }
        public string ProductCustomizationFieldName { get; set; }
        public string ProductCustomizationFieldValue { get; set; }
        public int CartItemAttributeId { get; set; }
        //public ICollection<OrderItemSubscription> OrderItemSubscriptions { get; set; }
    }
}
