using BLLObject= EcoTravel_BLL.Entities;
using DALObject=EcoTravel_DAL.Entities;
using BLLServ = EcoTravel_BLL.Services;
using DALServ = EcoTravel_DAL.Services;
using EcoTravel_Common.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using EcoTravel_ASPMVC.Handlers;

namespace EcoTravel_ASPMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            #region Service d'accessibilité du HttpContext par injection de dépendance (Voir chap. Session)
            services.AddHttpContextAccessor();
            #endregion

            #region Appel du sessionManager par injection de dépendance
            services.AddScoped<SessionManager>();
            #endregion

            #region Création du Cokie de la Session
            services.AddDistributedMemoryCache();
            services.AddSession(options=>
            {
                options.Cookie.Name = "EcoTravelSession";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(50);
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;
            });

            #endregion

            services.AddScoped<IClientRepository<BLLObject.Client, int>, BLLServ.ClientService>();
            services.AddScoped<IClientRepository<DALObject.Client, int>, DALServ.ClientService>();

            services.AddScoped<ILogementRepository<BLLObject.Logement, int>, BLLServ.LogementService>();
            services.AddScoped<ILogementRepository<DALObject.Logement, int>, DALServ.LogementService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseSession();
            app.UseCookiePolicy();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
