using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
     // [OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "genres")] //this is output Cache basically. so,basically using caching...we will improve our application performance.
     //but this is poor practice, as blindly storing data in cache we will increase memory consumption of application and secondly it will lead to all kinds of unneccesary Complxities both at the architectural and code level specially when we working with E.F
     // now imagine if we are changing or modyfying data using EF in that action in which we are storing data in cache, it leads to duplicate data or exception thrown by ef as modyfying data is not a part of cache which we use as data storing
     // Now, sometimes we want to cache a data not Html,now that data is perhaps modify in a time gap of let say 2yrs. now,we will use cache only if first we do performance profiling ,now let say i will do performance profilng and now i want to improve performance 
     //of my genre display list. so, i'll go now to my index action of customers controller and ( we use this approach  to improve performance for only those one to whom we want to display data not modyfying.eg genres) aplying changes to index action as to storimg data list of genres in cache. 
     //  [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)]  use this if we want to disable caching.
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
    }
}