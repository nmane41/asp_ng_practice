using MVCFormCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormCollection.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Detail(FormCollection collection) {
            TempData["uname"] = collection["userName"];
            TempData["pass"] = collection["password"];
            TempData.Keep();
            return View("UserView");
        }

        //public ActionResult BindDemo([Bind(Include ="Name, Password")]User user)
        //{
        //    TempData["uname"] = user.Name;
        //    TempData["password"] = user.Password;
        //    TempData["email"] = user.Email;
        //    return View();
        //}

        public ActionResult BindDemo([Bind(Exclude = "Age")] User user)
        {
            TempData["uname"] = user.Name;
            TempData["password"] = user.Password;
            TempData["email"] = user.Email;
            TempData["age"] = user.Age;
            return View();
        }
    }
}