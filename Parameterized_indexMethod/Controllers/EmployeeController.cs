using Parameterized_indexMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Parameterized_indexMethod.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        
        public ActionResult Index(int? Id, string name, string gender)
        {
            //ViewBag.Id = Id;
            //ViewBag.Name = name;
            //ViewData["Id"] = Id;
            //ViewData["Name"] = name;
            //ViewData["Gender"] = gender;
            TempData["Id"] = Id;
            TempData["Name"] = name;
            TempData["Gender"] = gender;
            //TempData.Keep();

            return View();
        }
        public ActionResult Second(int Id, string name, string gender)
        {
           var emp = new Employee(){ Id=Id, name = name, gender = gender};
            return View(emp);
        }

        [HttpGet]
        public ActionResult GetEmployee()
        {
            //Fetch data from the database
            //List<Employee> = DB.GetData();
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){Id=101, name = "Nitin", gender="Male"},
                new Employee(){Id=102, name = "Prakash", gender="Male"},
                new Employee(){Id=103, name = "Disha", gender="Female"},
                new Employee(){Id=104, name = "Nisha", gender="Female"},
                new Employee(){Id=105, name = "Rahul", gender="Male"}

            };
            //List<Customer> emp = new List<Customer>()
            //{
            //    new Customer(){Id=101, name = "Nitin", gender="Male"},
            //    new Customer(){Id=102, name = "Prakash", gender="Male"},
            //    new Customer(){Id=103, name = "Disha", gender="Female"},
            //    new Customer(){Id=104, name = "Nisha", gender="Female"},
            //    new Customer(){Id=105, name = "Rahul", gender="Male"}

            //};
            TempData["Employees"] = emp;

            return View();
        }

        public ActionResult EmployeeDetails()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){Id=101, name = "Nitin", gender="Male"},
                new Employee(){Id=102, name = "Prakash", gender="Male"},
                new Employee(){Id=103, name = "Disha", gender="Female"},
                new Employee(){Id=104, name = "Nisha", gender="Female"},
                new Employee(){Id=105, name = "Rahul", gender="Male"}

            };

            return View(emp);
        }
    }
}