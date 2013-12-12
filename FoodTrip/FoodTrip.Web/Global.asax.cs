using System;
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using FoodTrip.Dao.NHibernate;
using FoodTrip.Services;
using FoodTrip.Web.App_Start;
using Microsoft.Practices.Unity;

namespace FoodTrip.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterTypes();
        }

        protected void FormsAuthentication_OnAuthenticate(Object sender, FormsAuthenticationEventArgs e)
        {
            if (FormsAuthentication.CookiesSupported != true) return;
            if (Request.Cookies[FormsAuthentication.FormsCookieName] == null || string.IsNullOrEmpty(Request.Cookies[FormsAuthentication.FormsCookieName].Value)) return;
            var formsAuthenticationTicket = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value);
            if (formsAuthenticationTicket == null) return;

            var username = formsAuthenticationTicket.Name;

            var userService = UnityConfig.GetConfiguredContainer().Resolve<IUserService>();

            var user = userService.GetByUsername(username);

            e.User = new GenericPrincipal(new GenericIdentity(username, "Forms"), new[] { user.UserType.ToString() });
        }
    }
}
