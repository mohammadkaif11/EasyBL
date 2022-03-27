using System;
using System.ComponentModel.DataAnnotations;

namespace EasyBill.Data.Model
{
    public partial class Items
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BLID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
    }
}
