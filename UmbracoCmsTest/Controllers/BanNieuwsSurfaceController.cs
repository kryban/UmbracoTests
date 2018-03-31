using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using UmbracoCmsTest.Models;
using Umbraco.Web.Models;

namespace UmbracoCmsTest.Controllers
{
    public class BanNieuwsSurfaceController : RenderMvcController
    {
        public ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }
    }
}