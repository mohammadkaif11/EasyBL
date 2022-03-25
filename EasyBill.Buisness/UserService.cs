using EasyBill.Data.IReposistory;
using EasyBill.Data.Model;
using EasyBill.Data.Reposistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Buisness
{
    public class UserService : IUserService
    {
        readonly IUserReposistory _UserReposistory = null;
        public UserService()
        {
            this._UserReposistory = new UserReposistory();

        }
          public UserService(IUserReposistory userReposistory)
        {
            this._UserReposistory = userReposistory;

        }


        public int Register(User user)
        {
           int a=_UserReposistory.Add(user);
           return a;
        }

       
        public User Login(string userEmail, string password)
        {
            User user = _UserReposistory.Get(userEmail, password);
            return user;
        }
    }
}
