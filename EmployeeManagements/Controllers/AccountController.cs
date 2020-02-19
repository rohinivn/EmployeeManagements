using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagements.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUP()
        {
            ViewBag.Qualification = new SelectList("Qualification");
            ViewBag.City = new SelectList("City");
            ViewBag.State = new SelectList("State");
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}