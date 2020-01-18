using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCSample.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [Route("/myabout")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route("/mycontact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult mypage()
        {

            StudentEntities studentEntities = new StudentEntities();
            List<Student> students=studentEntities.Students.ToList();

            return View(students);
        }

        public ActionResult Success()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}