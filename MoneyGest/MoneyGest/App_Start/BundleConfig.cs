﻿using System.Web;
using System.Web.Optimization;

namespace MoneyGest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/toastr.js"
                       /* "~/Scripts/jquery-ui.js"*/));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                    "~/Scripts/Custom/form.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Login.css",
                      "~/Content/toastr.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/2016.1.112/css").Include(
                    "~/Content/kendo/2016.1.112/kendo.common.min.css",
                    "~/Content/kendo/2016.1.112/kendo.material.min.css"
                    ));

            bundles.Add(new StyleBundle("~/bundles/kendo").Include(
                      "~/Scripts/kendo/2016.1.112/kendo.all.min.js",
                      "~/Scripts/kendo/2016.1.112/kendo.aspnetmvc.min.js",
                      "~/Scripts/knockout.min.js"
                      //"~/Scripts/kendo/2016.1.112/jquery.min.js"
                      ));
        }
    }
}
