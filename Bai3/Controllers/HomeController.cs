using Bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3.ViewModels;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace Bai3.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController(){
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var um = _dbContext.Courses.Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            return View(um);    

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
    }
}