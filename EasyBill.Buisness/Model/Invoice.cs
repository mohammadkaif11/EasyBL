using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Buisness.Model
{
    public class Invoice
    {
        public int Id { get; set; } 
        public int BillSno { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public ICollection<BillItem> Billitem { get; set;}
        public decimal ToltalPrice { get; set; }
        public int ToltalItem { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime RecivedDate { get; set; }

    }
    public class BillItem {
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
    }

}
