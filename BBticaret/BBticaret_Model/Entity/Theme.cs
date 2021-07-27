using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Theme:BaseEntity
    {
        public ThemePlatform Platform { get; set; }
        public ThemeType Type { get; set; }
        public string Name { get; set; }
        public string Preset { get; set; }
        public string DirectoryName { get; set; }
        public bool Status { get; set; }
        public int Revision { get; set; }
        public int Version { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Attachment { get; set; }
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
    }
}
