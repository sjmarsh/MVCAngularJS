using System.Web;
using System.Web.Optimization;

namespace MVCAngularJS.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js",
                        "~/Scripts/angular-animate.min.js",
                        "~/Scripts/angular-touch.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/style").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/app.css"
                        ));

            

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;

        }
    }
}