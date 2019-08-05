using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTINwebAPI_2.Extensions;
using eTINwebAPI_2.Helper;
using eTINwebAPI_2.JWTAuth;
using eTINwebAPI_2.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace eTINwebAPI_2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static string ConnectionString { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.ConfigureCors();
        //    services.AddDbContext<eTINtestContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        //    //services.ConfigureIISIntregation();
        //    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        //        .AddJwtBearer(options => {
        //            options.SecurityTokenValidators.Add(new JWTAuthValidator(new HttpContextAccessor(), Configuration));
        //        });
        //    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }
        //    else
        //    {
        //        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //        app.UseHsts();
        //    }

        //    app.UseHttpsRedirection();

        //    app.UseCors("CorsPolicy");

        //    /* app.UseForwardedHeaders will forward 
        //        proxy headers to the current request.
        //        This will help us during the Linux deployment. */

        //    app.UseForwardedHeaders(new ForwardedHeadersOptions
        //    {
        //        ForwardedHeaders = ForwardedHeaders.All
        //    });

        //    /* app.UseStaticFiles() enables using static files for the request. 
        //        If we don’t set a path to the static files, 
        //            it will use a wwwroot folder in our solution explorer by default. */

        //    app.UseStaticFiles();

        //    app.UseMvc();
        //}



        /*This is from eTINwebAPI*/

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(config =>
            {
                var policy = new CorsPolicy();
                policy.Headers.Add("*");
                policy.Methods.Add("*");
                policy.Origins.Add("*");
                policy.SupportsCredentials = true;
                //config.AddPolicy("policy", policy);
            });

            //   services.AddMvc(o => o.InputFormatters.Insert(0, new EncryptedRequestBodyFormatter(Configuration)));
            services.AddDbContext<eTINtestContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddSingleton<ILogger, Logger>();
            services.AddSingleton<IConfiguration>(Configuration);
            //services.AddSingleton<IRJSCVerifier, RJSCVerifier>();
            services.AddSingleton<Utility>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {

                options.SecurityTokenValidators.Add(new JWTAuthValidator(new HttpContextAccessor(), Configuration));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
