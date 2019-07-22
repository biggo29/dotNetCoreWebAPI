using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin() //WithOrigins("http://www.something.com")
                .AllowAnyMethod() //WithMethods("POST", "GET")
                .AllowAnyHeader() //WithHeaders("accept", "content-type")
                .AllowCredentials());
            });
                
        }

        public static void ConfigureIISIntregation(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
                /* options.AutomaticAuthentication = true / false.Default true (Boolean). if true authentication middleware
                sets the HttpContext.User and response to generic challenges. If false the authentication
                middleware only provides an identity(HttpContext.User) and response to challenge when explicitly
                requested by AutheticationScheme.Windows authentication must be enabled in IIS for
                AutomaticAuthetication to perform. */

                //options.AutomaticAuthentication = false; 

                /* options.AuthenticationDisplayName. Default value is null (String). 
                Sets the display name to users on login pages. */

                //options.AuthenticationDisplayName = "Shoaib shahriar";

                /* options.ForwardClientCertificate = true or false (Boolean). If true and the 
                "MS-ASPNETCORE-CLIENTCERT" is present, the 'HttpContext.Connection.ClientCertificate'
                is populated. */

                //options.ForwardClientCertificate = true;
            });
        }
    }
}
