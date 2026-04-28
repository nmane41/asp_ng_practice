using EFDemo2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDemo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetStdData()
        {
            FirstDatabaseEntities dbContext = new FirstDatabaseEntities();
            List<StdData> stdData = dbContext.StdDatas.ToList();
            return View(stdData);
        }

        public ActionResult Edit(int id) {
            FirstDatabaseEntities databaseEntities = new FirstDatabaseEntities();
            StdData dt = databaseEntities.StdDatas.Find(id);
            return View(dt);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection stdData)
        {
            StdData stdData1 = new StdData();
            stdData1.roll = Convert.ToInt32(stdData["roll"]);
            stdData1.studentName = stdData["studentName"];
            stdData1.gender = stdData["gender"];
            stdData1.standard = Convert.ToInt32(stdData["standard"]);
            FirstDatabaseEntities databaseEntities = new FirstDatabaseEntities();

            databaseEntities.StdDatas.AddOrUpdate(stdData1);
            databaseEntities.SaveChanges();
            List<StdData> dt1 = databaseEntities.StdDatas.ToList();

            return View("GetStdData", dt1);
        }
}
}