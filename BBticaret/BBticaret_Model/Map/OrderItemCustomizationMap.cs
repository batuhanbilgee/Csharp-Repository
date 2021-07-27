using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OrderItemCustomizationMap:BaseMap<OrderItemCustomization>
    {
        public OrderItemCustomizationMap()
        {
            ToTable("dbo.OrderItemCustomizations");
            Property(x => x.ProductCustomizationGroupId).IsOptional();
            Property(x => x.ProductCustomizationGroupName).HasMaxLength(255).IsOptional();
            Property(x => x.ProductCustomizationGroupSortOrder).IsOptional();
            Property(x => x.ProductCustomizationFieldId).IsOptional();
            Property(x => x.ProductCustomizationFieldType).HasMaxLength(64).IsOptional();
            Property(x => x.ProductCustomizationFieldName).HasMaxLength(255).IsOptional();
            Property(x => x.ProductCustomizationFieldValue).HasMaxLength(65535).IsOptional();
            Property(x => x.CartItemAttributeId).IsOptional();
        }
    }
}
