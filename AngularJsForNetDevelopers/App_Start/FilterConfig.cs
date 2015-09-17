using System.Web;
using System.Web.Mvc;

namespace AngularJsForNetDevelopers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}