using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Data.IReposistory
{
    public interface IUserReposistory
    {
        int Add(User obj);
        User Get(string email, string password);
    }
}
