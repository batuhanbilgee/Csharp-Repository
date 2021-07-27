using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Preference:BaseEntity
    {
        //public Preference()
        //{
        //    Distributors = new HashSet<Distributor>();
        //}
        public string VarKey { get; set; }
        public string VarValue { get; set; }
        //public ICollection<Distributor> Distributors { get; set; }
    }
}
