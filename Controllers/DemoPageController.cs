using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class DemoPageController : Controller
    {
        // GET: DemoPage
        public string Index()
        {
            return "Hello Welcome to MVC";
        }
    }
}