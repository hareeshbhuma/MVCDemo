using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult  Index()
        {
            return View();
        }

        
        public String Welcome(String name="Bhuma",int id=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Id is: {id}");
        }
    }
}