using System.Web.Mvc;

namespace DnsWeb.Areas.iamadmin
{
    public class iamadminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "iamadmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "iamadmin_default",
                "iamadmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}