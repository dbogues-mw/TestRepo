using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_MVC_and_WebAPI.Attributes
{
    public class CustomTestAttribute : ActionFilterAttribute 
    {
        private string _testString;

        public CustomTestAttribute(string testString = "")
        {
            _testString = testString;
        }


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }



    }
}