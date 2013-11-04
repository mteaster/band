using System.Web;
using System.Web.Mvc;
using band.Stuff;

namespace band
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}