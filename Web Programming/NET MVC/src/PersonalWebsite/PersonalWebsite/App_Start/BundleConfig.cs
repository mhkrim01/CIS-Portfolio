using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace PersonalWebsite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
#if !DEBUG
            BundleTable.EnableOptimizations = true;
            BundleTable.Bundles.UseCdn = true;
#endif

            bundles.Add(new StyleBundle("~/Content/css", "https://stackpath.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/particles.css")
                .Include("~/Content/styles.css")
                .Include("~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/common-js", "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.0.0/jquery.min.js")
                .Include("~/Scripts/jquery-3.0.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/particles", "https://cdn.jsdelivr.net/npm/particles.js@2.0.0/particles.min.js")
                .Include("~/Scripts/particles.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app-js")
                .Include("~/Scripts/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/unclickable")
                .Include("~/Scripts/unclickable.js"));

            bundles.Add(new ScriptBundle("~/bundles/trackLink")
                .Include("~/Scripts/trackLink.js"));

            bundles.Add(new ScriptBundle("~/bundles/google-analytics")
                .Include("~/Scripts/google-analytics.js"));
        }
    }
}