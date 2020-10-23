using BlogPessoal.Web.Filtros;
using System.Web.Mvc;

namespace BlogPessoal.Web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AiHandleErrorAttribute());
            //filters.Add(new ExibirArtigosActionFilter());
        }
    }
}