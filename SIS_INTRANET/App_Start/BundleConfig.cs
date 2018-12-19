using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SIS_INTRANET
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/assets/css/bootstrap.min.css",
                "~/assets/font-awesome/4.2.0/css/font-awesome.min.css",
                "~/assets/fonts/fonts.googleapis.com.css",
                "~/assets/css/ace.min.css"                           
                ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/assets/js/bootstrap.min.js",
                "~/assets/js/excanvas.min.js",
                "~/assets/js/jquery-ui.custom.min.js",
                "~/assets/js/jquery.ui.touch-punch.min.js",
                "~/assets/js/jquery.easypiechart.min.js",
                "~/assets/js/jquery.sparkline.min.js",
                "~/assets/js/jquery.flot.min.js",
                "~/assets/js/jquery.flot.pie.min.js",
                "~/assets/js/jquery.flot.resize.min.js",
                "~/assets/js/ace-elements.min.js",
                "~/assets/js/ace.min.js",
                "~/assets/js/ace-extra.min.js",
                "~/assets/js/jquery.2.1.1.min.js"
                ));
        }
    }
}