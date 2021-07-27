using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ProductImage:BaseEntity
    {
        public string FileName { get; set; }
        public ProductImageExtension Extension { get; set; }
        public string DirectoryName { get; set; }
        public string Revision { get; set; }
        public int SortOrder { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Attachment { get; set; }
    }
}
