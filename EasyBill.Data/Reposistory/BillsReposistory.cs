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
     public class BillsReposistory:IBillsReposistory
    {
        private EasyBillContext context;
        private DbSet<Bills> table = null;

        public BillsReposistory()
        {
            this.context = new EasyBillContext();
            table = context.Set<Bills>();
        }


        public BillsReposistory(EasyBillContext context)
        {
            this.context = new EasyBillContext();
            table = context.Set<Bills>();
        }
     
    
        public int AddBills(Bills obj)
        {
            try
            {
                table.Add(obj);
                int a = context.SaveChanges();
                return a;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return -1;
            }
        }

        public List<Bills> GetBills(int id)
        {
            return table.Where(x => x.UserID == id).ToList();
        }

        public List<Bills> GetBillsByDate(int id, DateTime date)
        {
            try
            {
                return table.Where(x => x.UserID == id && x.RecivedDate.Date.Equals(date)).ToList();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;
            }
        }
       

        //Month
        public List<Bills> GetBillsByMonth(int id, int mon)
        {
            try
            {
                return table.Where(x => x.UserID == id && x.RecivedDate.Date.Month.Equals(mon)).ToList();

            }catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return null;    
            }
        }
    }
}
