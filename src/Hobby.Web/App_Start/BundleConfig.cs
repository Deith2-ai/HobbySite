using System.Web;
using System.Web.Optimization;

namespace Hobby.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterLayout(bundles);

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                         "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/CSS").Include(
                    "~/Scripts/AdminLTE/bootstrap/css",
                    "~/Scripts/AdminLTE/dist/css",
                    "~/Scripts/AdminLTE/dist/skins/css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }

        public static void RegisterLayout(BundleCollection bundles)
        {
            // plugins | font-awesome
            //bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/font-awesome/css").Include(
            //    "~/Scripts/AdminLTE/plugins/font-awesome/css/font-awesome.min.css"));

            //// plugins | ionicons
            //bundles.Add(new StyleBundle("~/Scripts/AdminLTE/plugins/ionicons/css").Include(
            //    "~/Scripts/AdminLTE/plugins/ionicons/css/ionicons.min.css"));

            // bootstrap
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/bootstrap/js").Include(
                "~/Scripts/AdminLTE/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/bootstrap/css").Include(
                "~/Scripts/AdminLTE/bootstrap/css/bootstrap.min.css"));

            //// dist
            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/dist/js").Include(
               "~/Scripts/AdminLTE/dist/js/app.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/dist/css").Include(
                "~/Scripts/AdminLTE/dist/css/admin-lte.min.css"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE/dist/css/skins").Include(
                "~/Scripts/AdminLTE/dist/css/skins/_all-skins.min.css"));

            // plugins | slimscroll
            //bundles.Add(new ScriptBundle("~/Scripts/AdminLTE/plugins/slimscroll/js").Include(
            //     "~/Scripts/AdminLTE/plugins/slimscroll/js/jquery.slimscroll.min.js"));
        }
    }
}
