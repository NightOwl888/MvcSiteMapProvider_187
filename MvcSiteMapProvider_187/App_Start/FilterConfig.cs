using System.Web;
using System.Web.Mvc;

namespace _187_AuthorizeAttribute
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}