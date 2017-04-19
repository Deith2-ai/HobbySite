using Hobby.Common;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;
using Microsoft.Owin.Security.Google;
using Owin;

namespace Hobby.Web.App_Start
{
    public class Startup
    {
        public static void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ourType",
                LoginPath = new PathString(Config.LoginUrl)
            });

            appBuilder.UseFacebookAuthentication(new FacebookAuthenticationOptions
            {
                AppId = "1888736071363331",
                AppSecret = "fa75a3bd57fb26f1bd332ae5daa49ed6",
                SignInAsAuthenticationType = "ourType",
            });

            appBuilder.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions
            {
                ClientId = "24232919438-mjjnuv8ju9pnmh99b9qv9o1gbqf4f3pl.apps.googleusercontent.com",
                ClientSecret = "PorJkXHKjdayZVdKbdq-vYym",
                SignInAsAuthenticationType = "ourType",
            });
        }
    }
}