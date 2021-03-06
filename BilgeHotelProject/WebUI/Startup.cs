using Business.IocContainer;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Proxies;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using WebUI.Utilities;
using Microsoft.AspNetCore.Http;

namespace WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseLazyLoadingProxies();
                x.UseSqlServer(Configuration.GetConnectionString("defaultConnection"), x => x.MigrationsAssembly("DataAccess"));
            });

            services.AddIdentity<AppUser, IdentityRole>(x =>
            {
                x.Password.RequireDigit = true;
                x.Password.RequireLowercase = true;
                x.Password.RequireUppercase = true;
                x.Password.RequiredLength = 8;
                x.Password.RequireNonAlphanumeric = false;
            }).AddErrorDescriber<CustomValidation>().AddEntityFrameworkStores<AppDbContext>();

            services.ConfigureServices(); //Ioc containerda extension metot oluşturuldu.

            //AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //Session
            //services.AddSession(x =>
            //{
            //    x.Cookie.Name = "user.Session";
            //    x.IdleTimeout = TimeSpan.FromMinutes(5);
            //});

            //Cookie
            services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = new PathString("/Account/Login");
                x.AccessDeniedPath = new PathString("/Account/Denied");
                x.Cookie = new CookieBuilder
                {
                    Name = "userAuthCookie"
                };
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); //External style ve script file ları tanıtmak için yazılır.

            app.UseRouting();

            app.UseAuthentication(); //Kimlik yönetimi
            app.UseAuthorization(); //Yetki Yönetimi

            //app.UseSession(); //Session

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
