using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coffeeshop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {

        [Authorize(Roles = "admin")]
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
    }
}