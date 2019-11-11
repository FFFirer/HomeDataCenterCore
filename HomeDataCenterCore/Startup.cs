using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HomeDataCenterCore.Services;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using HomeDataCenterCore.Domain.AppSettings;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace HomeDataCenterCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<SqlConnectionOption>(Configuration.GetSection("MyConnections"));
            services.AddLogging(logbuilder =>
            {
                logbuilder.ClearProviders();
                logbuilder.AddNLog("NLog.config");
            });
            services.AddControllersWithViews();
            services.AddScoped<IBodyDataService, BodyDataService>();
            services.AddScoped<IFilmDataService, FilmDataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // 静态文件、路由
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
            });
        }
    }
}
