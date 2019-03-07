using System.Web;
using System.Web.Mvc;

namespace Unidad_3_Eduardo_Albarizaez
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
