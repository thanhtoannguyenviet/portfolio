using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession();
            
            services.AddDbContext<MvcCertificationContext>(options =>

            options.UseSqlServer("Server=115.73.214.162;Database=c1908i3_bao;User Id=c1908i3_usr_baodb;Password=123456"));
            //options.UseSqlServer("Server=115.73.214.162,1433;Database=c1908i3_bao;User Id=c1908i3_usr_baodb;Password=123456"));
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=certification}/{action=index}/{id?}");
            });

        }
    }
}
