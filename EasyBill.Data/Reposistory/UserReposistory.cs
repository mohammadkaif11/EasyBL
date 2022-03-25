﻿using EasyBill.Data.Context;
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
    public class UserReposistory : IUserReposistory
    {

        private EasyBillContext context;
        private DbSet<User> table = null;

        public UserReposistory()
        {
            this.context = new EasyBillContext();
            table = context.Set<User>();
        }


        public UserReposistory(EasyBillContext context)
        {
            this.context = new EasyBillContext();
            table = context.Set<User>();
        }


        public int Add(User obj)
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
                return 0;
            }
        }

        public User Get(string email, string password)
        {
            User user = new User();
            try
            {
                 user = table.Where(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(password)).FirstOrDefault();
                if (user != null)
                {
                    return user;
                }
                return user;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return user;
            }

        }

    
    }
}
