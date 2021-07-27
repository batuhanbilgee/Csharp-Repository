using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Enums
{
    public enum PaymentStatus
    {
        deleted,
        waiting_for_approval,
        approved, fulfilled, 
        cancelled, delivered, 
        on_accumulation, 
        waiting_for_payment,
        being_prepared, 
        refunded,
        personal_status_1,
        personal_status_2, 
        personal_status_3, 
        failed,
        in_transaction
    }
}
