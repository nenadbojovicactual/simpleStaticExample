using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.ActionFilter
{
    public class CreateAction : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            testx();
        }
        public static void testx()
        {
            Debug.WriteLine("OnActionExecuting", "yo");
        }
    }
   
}
