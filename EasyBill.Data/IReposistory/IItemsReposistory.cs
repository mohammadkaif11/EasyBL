using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Data.IReposistory
{
    public interface IItemsReposistory
    {
        int AddItems(Items obj);

        List<Items> GetItems(int id);

        //Get By Month
        List<Items> GetItemsByMonth(int id ,int Month);

        //get by particular date
        List<Items> GetItemsByDate(int id,DateTime date);



    }
}
