using EasyBill.Buisness.Model;
using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Buisness
{
    public interface IBillService
    {
        Invoice Insert(int id, Bills obj, IEnumerable<Items> dept);
       
    }
}
