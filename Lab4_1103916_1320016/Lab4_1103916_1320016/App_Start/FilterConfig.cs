using System.Web;
using System.Web.Mvc;

namespace Lab4_1103916_1320016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
