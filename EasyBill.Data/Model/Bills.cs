using System;
using System.ComponentModel.DataAnnotations;

namespace EasyBill.Data.Model
{
    public partial class Bills
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BLID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public DateTime RecivedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalItem { get; set; }
    }
}
