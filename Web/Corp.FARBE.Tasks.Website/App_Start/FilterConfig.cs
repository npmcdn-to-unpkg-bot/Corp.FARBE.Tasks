using System.Web;
using System.Web.Mvc;

namespace Corp.FARBE.Tasks.Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
