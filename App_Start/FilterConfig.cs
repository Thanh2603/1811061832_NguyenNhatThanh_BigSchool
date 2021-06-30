using System.Web;
using System.Web.Mvc;

namespace _1811061832_NguyenNhatThanh_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
