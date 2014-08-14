using System.Web;
using System.Web.Optimization;

namespace MongoTodo {
    public class BundleMobileConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new  ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.mobile-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate.js", 
                "~/Scripts/jquery.validate.unobtrusive.js"));
            
            bundles.Add(new StyleBundle("~/Content/jquerymobile/css").Include(
                "~/Content/jquery.mobile-{version}.css"));
        }
    }
}