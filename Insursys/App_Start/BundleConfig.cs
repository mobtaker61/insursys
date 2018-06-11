using System.Web.Optimization;

namespace Insursys
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region PANEL css
            bundles.Add(new StyleBundle("~/Content/_panel/css").Include(
            //"~/Content/_panel/assets/skin/default_skin/css/style.css",
            "~/Content/_panel/vendor/plugins/fullcalendar/fullcalendar.min.css", // RTL YES
            "~/Content/_panel/assets/skin/default_skin/css/theme.css", // RTL YES
            "~/Content/_panel/assets/admin-tools/admin-forms/css/admin-forms.min.css", // RTL YES
            //"~/Content/_panel/assets/web/css/style_admin.css",
            "~/Content/_panel/assets/admin-tools/admin-plugins/admin-panels/adminpanels.css" // RTL YES
            ));
            #endregion

            #region PANEL jquery_head
            bundles.Add(new ScriptBundle("~/Content/_panel/jquery_head").Include("~/Content/_google_2.2.4/js/jquery.min.js"));
            #endregion

            #region PANEL jquery_foot
            bundles.Add(new ScriptBundle("~/Content/_panel/jquery_foot").Include(
            //jQuery
            "~/Content/_panel/vendor/jquery/jquery-1.11.1.min.js",
            "~/Content/_panel/vendor/jquery/jquery_ui/jquery-ui.min.js",
            //Admin Chart Plugins
            "~/Content/_panel/vendor/plugins/highcharts/highcharts.js",
            "~/Content/_panel/vendor/plugins/jvectormap/jquery.jvectormap.min.js",
            "~/Content/_panel/vendor/plugins/jvectormap/assets/jquery-jvectormap-us-lcc-en.js",
            "~/Content/_panel/vendor/plugins/fullcalendar/lib/moment.min.js",
            "~/Content/_panel/vendor/plugins/fullcalendar/fullcalendar.min.js",
            "~/Content/_panel/vendor/plugins/fileupload/fileupload.js",
            //Admin Theme Javascript
            "~/Content/_panel/assets/js/utility/utility.js",
            
            "~/Content/_panel/assets/js/demo/demo.js",
            "~/Content/_panel/assets/js/main.js",
            //Admin Panels
            "~/Content/_panel/assets/js/demo/widgets.js"
            //Admin Panels
            //"~/Content/_panel/assets/admin-tools/admin-plugins/admin-panels/json2.js",
            //"~/Content/_panel/assets/admin-tools/admin-plugins/admin-panels/jquery.ui.touch-punch.min.js",
            //"~/Content/_panel/assets/admin-tools/admin-plugins/admin-panels/adminpanels.js",
            //Admin JS
            //"~/Content/_panel/down_JS.js"
            ));
            #endregion

            #region Login
            bundles.Add(new StyleBundle("~/Content/_login/css").Include("~/Content/_panel/assets/skin/default_skin/css/theme.css",
                "~/Content/_panel/vendor/plugins/select2/css/core.css",
                "~/Content/_panel/assets/admin-tools/admin-forms/css/admin-forms.css"));
            #endregion
        }
    }
}
