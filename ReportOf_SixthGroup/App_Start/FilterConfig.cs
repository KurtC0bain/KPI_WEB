using System.Web;
using System.Web.Mvc;

namespace ReportOf_SixthGroup
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
