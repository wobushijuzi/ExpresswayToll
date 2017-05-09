using System.Web;
using System.Web.Optimization;

namespace ExpresswayToll
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //脚本
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/platform/global").Include(
                      "~/Content/assets/global/scripts/app.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/platform/layout").Include(
                      "~/Content/assets/layouts/layout/scripts/layout.min.js",
                      "~/Content/assets/layouts/layout/scripts/demo.min.js",
                      "~/Content/assets/layouts/global/scripts/quick-sidebar.min.js",
                      "~/Content/assets/layouts/global/scripts/quick-nav.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/platform/login").Include(
                        "~/Content/assets/global/plugins/js.cookie.min.js",
                        "~/Content/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/Content/assets/global/plugins/jquery.blockui.min.js",
                        "~/Content/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                        "~/Content/assets/global/plugins/jquery-validation/js/jquery.validate.js",
                        "~/Content/assets/global/plugins/jquery-validation/js/additional-methods.min.js",
                        "~/Content/assets/global/plugins/select2/js/select2.full.min.js",
                        "~/Content/assets/global/plugins/backstretch/jquery.backstretch.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/platform/table").Include(
                        "~/Content/assets/global/scripts/datatable.js",
                        "~/Content/assets/global/plugins/datatables/datatables.min.js",
                        "~/Content/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.js"
                        //"~/Content/assets/global/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js",
                        //"~/Content/assets/pages/scripts/ecommerce-orders.min.js"
                        ));
            //样式
            bundles.Add(new StyleBundle("~/Content/css/global").Include(
                      "~/Content/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                      "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                      "~/Content/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                      "~/Content/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                      "~/Content/assets/global/css/components.min.css",
                      "~/Content/assets/global/css/plugins.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/layout").Include(
                      "~/Content/assets/layouts/layout/css/layout.min.css",
                      "~/Content/assets/layouts/layout/css/themes/darkblue.min.css",
                      "~/Content/assets/layouts/layout/css/custom.min.css"));
            bundles.Add(new StyleBundle("~/Content/login").Include(
                      "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                      "~/Content/assets/global/plugins/select2/css/select2.min.css",
                      "~/Content/assets/global/plugins/select2/css/select2-bootstrap.min.css",
                      "~/Content/assets/pages/css/login.min.css"));
            bundles.Add(new StyleBundle("~/Content/css/table").Include(
                    "~/Content/assets/global/plugins/datatables/datatables.min.css",
                    "~/Content/assets/global/plugins/datatables/plugins/bootstrap/datatables.bootstrap.css"
                    //"~/Content/assets/global/plugins/bootstrap-datepicker/css/bootstrap-datepicker3.min.css"
                    ));

        }
    }
}
