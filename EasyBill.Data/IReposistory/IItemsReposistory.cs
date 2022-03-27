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

    }
}
