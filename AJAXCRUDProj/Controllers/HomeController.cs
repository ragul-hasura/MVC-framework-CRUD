using AJAXCRUDProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXCRUDProj.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDB empDB = new EmployeeDB();

        // GET: Home
        public ActionResult Index()
        {
            return View(empDB);
        }
       
        public ActionResult List()
        {
            //EmployeeDB empDB1 = new EmployeeDB();
            return View(empDB.ListAll());
            //Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Test()
        {
            //EmployeeDB empDB1 = new EmployeeDB();
            return View();
            //Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Test(Employee emp)
        {

            SendDetails empDB1 = new SendDetails();
            string status = empDB1.InsertData(emp);
            return View();
            //Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            //EmployeeDB empDB1 = new EmployeeDB();
            return View(empDB.ListAll());
            //Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
        }
    }
}