using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Data.IReposistory
{
    public interface IBillsReposistory
    {
        int AddBills(Bills obj);

        //Get allBill 
        List<Bills> GetBills(int id);

        //Get Data By Month 
        List<Bills> GetBillsByMonth(int id,int Month);

        //Get Data By Particular Date
        List<Bills> GetBillsByDate(int id,DateTime date);



    }
}
