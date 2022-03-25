using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Buisness
{
    public interface IUserService
    {
        int Register(User user);
        User Login(string userEmail, string password);
    }
}
