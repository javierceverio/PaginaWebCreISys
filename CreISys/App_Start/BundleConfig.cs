using System.Web.Optimization;

namespace CreISys
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Cargamos todos los estilos del template
            bundles.Add(new StyleBundle("~/Assets/css").Include(
                      "~/Assets/css/bootstrap.min.css",
                      "~/Assets/css/font-awesome.css",
                      "~/Assets/css/fñex-slider.css",
                      "~/Assets/css/templatemo-softy-pinko.css"));

            // Cargamos todos los scripts
            bundles.Add(new ScriptBundle("~/Assets/js").Include(
                      "~/Assets/js/waypoints.min.js",
                      "~/Assets/js/bootstrap.min.js",
                      "~/Assets/js/imgfix.min.js",
                      "~/Assets/js/jquery-2.1.0.min.js",
                      "~/Assets/js/jquery.counterup.min.js",
                      "~/Assets/js/popper.js",
                      "~/Assets/js/scrollreveal.min.js",
                      "~/Scripts/custom.js"));
        }
    }
}
