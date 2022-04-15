using System.Web;
using System.Web.Optimization;

namespace EasyBill.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/Chart").Include("~/Content/Chart.css", "~/Content/Chart.min.css"));

            bundles.Add(new StyleBundle("~/Content/App").Include("~/Content/App.css").Include("~/Content/Bill.css"));
            bundles.Add(new ScriptBundle("~/Scripts/App").Include("~/Scripts/App.js").Include("~/Scripts/CreateBill.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Bill").Include("~/Scripts/CreateBill.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Chart").Include("~/Scripts/Chart.js").Include("~/Scripts/Chart.min.js"));



        }
    }
}
