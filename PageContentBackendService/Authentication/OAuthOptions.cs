using PageContentBackendService.Configuration;
using PageContentBackendService.Services;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using System;

namespace PageContentBackendService.Authentication
{
    public class OAuthOptions : OAuthAuthorizationServerOptions
    {
        public OAuthOptions(Lazy<IAuthConfiguration> lazyAuthConfiguration, IIdentityService identityService)
        {
            _lazyAuthConfiguration = lazyAuthConfiguration;
            TokenEndpointPath = new PathString(_authConfiguration.TokenPath);
            AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(_authConfiguration.ExpirationMinutes);
            AccessTokenFormat = new JwtWriterFormat(lazyAuthConfiguration, this);
            Provider = new OAuthProvider(lazyAuthConfiguration, identityService);
            AllowInsecureHttp = true;
        }

        protected IAuthConfiguration _authConfiguration { get { return _lazyAuthConfiguration.Value; } }
        protected Lazy<IAuthConfiguration> _lazyAuthConfiguration;

    }
}
