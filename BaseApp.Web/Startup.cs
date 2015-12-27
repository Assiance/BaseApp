using BaseApp.Domain.Services;
using BaseApp.Domain.Services.Interfaces;
using BaseApp.Web;

using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace BaseApp.Web
{
    public class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static string PublicClientId { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            var oAuthService = new ApplicationOAuthService();
            oAuthService.ConfigureAuth(app, PublicClientId, OAuthOptions);
        }
    }
}
