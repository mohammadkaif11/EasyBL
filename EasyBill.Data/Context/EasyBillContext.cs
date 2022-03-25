using EasyBill.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBill.Data.Context
{
    public class EasyBillContext: DbContext
    {
        public EasyBillContext() : base("name=EasyBL")
        {
            Database.SetInitializer<EasyBillContext>(new CreateDatabaseIfNotExists<EasyBillContext>());
        }
        public DbSet<User> user { get; set; }
        public DbSet<Bills> bills { get; set; }
        public DbSet<Items> items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
