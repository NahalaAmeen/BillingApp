using System.Web;
using System.Web.Optimization;

namespace BiilingWebApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/Js/Common").Include(
                               "~/Assets/scripts/common.min.js",
                               "~/Assets/scripts/uikit_custom.js",
                               "~/Assets/scripts/altair_admin_common.js",
                               "~/Assets/scripts/plugins/jquery.inputmask.bundle.min.js",
                               "~/Assets/scripts/app.js",
                               "~/Assets/scripts/Config.js"
                               ));

            bundles.Add(new ScriptBundle("~/Js/DataTable").Include(
                               "~/Assets/scripts/plugins/datatables/jquery.dataTables.js",
                               "~/Assets/scripts/plugins/datatables/dataTables.uikit.min.js"
                                ));

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

            bundles.Add(new StyleBundle("~/Css/Common").Include(
                                 "~/Assets/css/uikit/uikit.almost-flat.css",
                                 "~/Assets/css/main.css",
                                 "~/Assets/css/theme_Version1.css",
                                 "~/Assets/css/additional_Version.css",
                                 "~/Assets/css/custom.css"
                                 ));

        }
    }
}
