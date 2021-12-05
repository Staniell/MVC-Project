using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mp.Controllers
{
    public class Admin_LoginController : Controller
    {
        // GET: Admin_Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string emp_id, string emp_pass)
        {
            if(emp_id.StartsWith("admin_"))
            {
                bool correct_name = false;

                Borrowerx borrowerz = new Borrowerx(emp_id, emp_pass);
                Operationx operation = new Operationx();
                correct_name = operation.Login(borrowerz);

                if (correct_name)
                {
                    Session["Admin_Log"] = emp_id;
                    return RedirectToAction("Index", "Books");
                }
                return View();
            }
            return View();
        }
    }
}