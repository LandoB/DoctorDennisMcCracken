using System.Web;
using System.Web.Mvc;

namespace DoctorDennisMcCracken
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
