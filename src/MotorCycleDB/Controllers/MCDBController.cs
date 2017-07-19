using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorCycleDB.Controllers
{
    public class MCDBController : Controller
    {
        // Directs the browser to the "Home or index" page
        public ActionResult Index()
        {
            return View();
        }

    }
}