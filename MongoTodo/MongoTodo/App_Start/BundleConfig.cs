using System.Web;
using System.Web.Optimization;

namespace MongoTodo
{
    public class BundleConfig
    {
        // Weitere Informationen zu Bundling finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=301862"
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquerymobile")
                /*.Include("~/Scripts/jquery.mobile-{version}.js")*/
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/Mobile/css")
                .Include("~/Content/Site.Mobile.css")
                .Include("~/Content/jquery.mobile-{version}.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            // Festlegen von "EnableOptimizations" auf "false" für Debugzwecke. Weitere Informationen
            // finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=301862".
            BundleTable.EnableOptimizations = true;
        }
    }
}
