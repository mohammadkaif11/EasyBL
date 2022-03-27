using EasyBill.Data.Context;
using EasyBill.Data.IReposistory;
using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Data.Reposistory
{
    public class ItemsReposistory:IItemsReposistory
    {
        private EasyBillContext context;
        private DbSet<Items> table = null;

        public ItemsReposistory()
        {
            this.context = new EasyBillContext();
            table = context.Set<Items>();
        }


        public ItemsReposistory(EasyBillContext context)
        {
            this.context = new EasyBillContext();
            table = context.Set<Items>();
        }

        public int AddItems(Items obj)
        {
            try
            {
                table.Add(obj);
                int a = context.SaveChanges();
                return a;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.InnerException);
                return -1;
            }
            

        }
    }
}
