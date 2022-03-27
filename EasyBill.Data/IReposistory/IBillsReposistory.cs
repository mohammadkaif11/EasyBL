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
    }
}
