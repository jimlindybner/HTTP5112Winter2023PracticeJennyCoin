using System.Web;
using System.Web.Mvc;

namespace HTTP5112Winter2023PracticeJennyCoin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
