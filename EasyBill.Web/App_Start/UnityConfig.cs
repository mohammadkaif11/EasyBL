using EasyBill.Buisness;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace EasyBill.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IBillService, BillService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}