using System.Web;
using System.Web.Optimization;

namespace DemoCode
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery-3.4.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

        
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr/modernizr-2.8.3"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/createnewaccount/js").Include(
                       "~/Scripts/createnewaccount/createnewaccount.js"));


            bundles.Add(new ScriptBundle("~/bundles/UserRecord").Include(
                        "~/Scripts/UserRecords/userrecord.js",
                        "~/Scripts/managepager/managepager.js" ));

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                      "~/Scripts/chart/fusioncharts.js",
                      "~/Scripts/chart/fusioncharts.charts.js",
                      "~/Scripts/Themes/fusioncharts.theme.zune.js",
                      "~/Scripts/chart/chart.js"
                      ));




            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap/bootstrap-theme.css",
                      "~/Content/site/Site.css"));


            bundles.Add(new StyleBundle("~/Content/createnewaccount/css").Include(
                      "~/Content/createnewaccount/createnewaccount.css"));
                      
        }
    }
}
