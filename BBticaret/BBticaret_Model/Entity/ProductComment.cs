using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ProductComment:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public ProductCommentRank Rank { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }



    }
}
