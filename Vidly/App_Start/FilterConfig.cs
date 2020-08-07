using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());    //globally add authorization 
            filters.Add(new RequireHttpsAttribute());  //bcs of this our previous URL do not work now,only ssl URL will work.
        }
    }
}
