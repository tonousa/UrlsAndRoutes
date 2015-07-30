using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace UrlsAndRoutes.Infrastructure
{
    public class LegacyRoute : RouteBase
    {
        private string[] urls;

        public LegacyRoute(params string[] targetUrls)
        {

        }
    }
}