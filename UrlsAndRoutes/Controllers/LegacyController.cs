﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class LegacyController : Controller
    {
        //
        // GET: /Legacy/

        public ActionResult GetLegacyUrl(string legacyUrl)
        {
            return View((object)legacyUrl);
        }

    }
}
