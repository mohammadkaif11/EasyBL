using EasyBill.Buisness.Model;
using EasyBill.Data.IReposistory;
using EasyBill.Data.Model;
using EasyBill.Data.Reposistory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Buisness
{
    public class BillService : IBillService
    {

        private readonly IBillsReposistory _BillReposistory = null;
        private readonly IItemsReposistory _ItemsReposistory = null;
        private readonly IUserReposistory _UserReposistory = null;  


        public BillService()
        {
            _BillReposistory = new BillsReposistory(); 
            _ItemsReposistory = new ItemsReposistory();
            _UserReposistory = new UserReposistory();
        }


        public BillService(IBillsReposistory billsReposistory, ItemsReposistory itemsReposistory, UserReposistory userReposistory)
        {
            this._BillReposistory = billsReposistory;
            this._ItemsReposistory = itemsReposistory;
            this._UserReposistory = userReposistory;
        }






        //Insert of Bill
        public Invoice Insert(int id, Bills obj, IEnumerable<Items> dept)
        {
            //Create two Variable for Verification of database operation
            int result = 0;
            int result2 = 0;


            //CreateInvoice Model Object
            Invoice invoice = new Invoice();
            List<BillItem> billItems = new List<BillItem>();

 

            //Fetch user with id
            User user = _UserReposistory.FindById(id);
                if (user != null)
                {

                //TotalAmount and TotalItem
                int _totalprice = 0;
                int TotalItems = 0;
                int BillSno = user.UserBillSno;

                    foreach (Items Item in dept)
                    {
                        _totalprice += (int)Item.ItemPrice * Item.ItemQuantity;
                        TotalItems = TotalItems + Item.ItemQuantity;
                        billItems.Add(new BillItem() { ItemName=Item.ItemName,ItemQuantity=Item.ItemQuantity,ItemPrice=Item.ItemPrice});
                        Item.BLID = BillSno;
                        Item.UserID = id;
                        
                        int n = _ItemsReposistory.AddItems(Item);
                        if (n > 0)
                        {
                            result++;
                        }
                        else
                        {
                            result = 0;
                            break;
                        }
                    }  
                    invoice.Billitem = billItems;
                    if (result > 0)
                    {
                        obj.UserID = id;
                        obj.TotalAmount = _totalprice;
                        obj.TotalItem = TotalItems;
                        obj.RecivedDate = DateTime.Now;
                        obj.BLID = BillSno;

                        //Add value Invoice  object
                        invoice.Id = BillSno;
                        invoice.ToltalPrice =_totalprice;
                        invoice.ToltalItem = TotalItems;
                        invoice.CustomerName = obj.CustomerName;
                        invoice.CustomerPhone = obj.CustomerPhoneNumber;
                        invoice.RecivedDate = obj.RecivedDate;
                        invoice.DeliveryDate = obj.DeliveryDate;
                     
                        // Add Object of Bills In Database 
                        result2 = _BillReposistory.AddBills(obj);
                        if (result2 > 0 && result > 0)
                        {
                            //update value of Serial
                            int a = _UserReposistory.UpdateBillSno(id);
                            if (a >0){
                                return invoice;
                            }
                            return null;
                        }
                    return null;
                    }
                }

                return null;
           
        }
    }

}

