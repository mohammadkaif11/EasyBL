using System;
using System.ComponentModel.DataAnnotations;

namespace EasyBill.Data.Model
{
    public partial class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserShopName { get; set; }
        public string UserShoAddress { get; set; }
        public string UserPhoneNumber { get; set; }
        public DateTime UserJoinData { get; set; }
        public int BillSno { get; set; }  

    }

}
