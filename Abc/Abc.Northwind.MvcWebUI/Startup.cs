using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Business.Concrete;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.DataAccess.Concrete.EntityFramework;
using Abc.Northwind.MvcWebUI.Entities;
using Abc.Northwind.MvcWebUI.Middlewares;
using Abc.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Abc.Northwind.MvcWebUI
{
    public class Startup
    {
        //dependency injection alan�
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal,EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddScoped<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<CustomIdentityDbContext>(options =>
                options.UseSqlServer(
                    @"Data Source = (localdb)\MSSQLLocalDB; Database = Northwind; Integrated Security = True; "));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityDbContext>();

            services.AddSession();
            //session'� bellekte tutaca��n� bildirdik.
            services.AddDistributedMemoryCache();

            //endpoints middleware'ini kullanmamak i�in i�ine sorgu yazd�k.
            services.AddMvc(options => options.EnableEndpointRouting = false);

            //css'i browserda e�zamanl� de�i�tirsin diye ekledik.
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        //middleware yap�land�rmas�n�n ger�ekle�tirildi�i yer
        //hata yakalama loglama gibi i�lemler yaz�labilir
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseSession();

            app.UseFileServer();

            //custom middleware
            app.UseNodeModules(env.ContentRootPath);

            app.UseMvc(ConfigureRoutes);


            //Endpoints middleware
            //app.UseRouting();


        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Product}/{action=Index}/{id?}");
        }
    }
}
