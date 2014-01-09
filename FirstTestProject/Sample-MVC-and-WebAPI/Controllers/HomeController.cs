using Sample_MVC_and_WebAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample_MVC_and_WebAPI.Models;

namespace Sample_MVC_and_WebAPI.Controllers
{
    public partial class HomeController : Controller
    {
        //
        // GET: /Home/

        public virtual ActionResult Index()
        {
            IndexModel model = new IndexModel();
            return View(model);
        }


        [CustomTest("Some Test Text")]
        public virtual ActionResult TestControllerAttribute()
        {
            return View();
        }


    }
}
