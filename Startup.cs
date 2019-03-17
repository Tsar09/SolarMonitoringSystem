using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SolarMonitoringSystem.Infrastructure;
using Prometheus;
using SolarMonitoringSystem.Repository;
using SolarMonitoringSystem.Repository.Interfaces;
using SolarMonitoringSystem.Services.Interfaces;
using SolarMonitoringSystem.Services;
using SolarMonitoringSystem.Tasks;
using Microsoft.Extensions.Hosting;

namespace SolarMonitoringSystem
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
            services.AddMvc();

            services.AddOptions();
            services.Configure<ModbusSlaveConfiguration>(Configuration.GetSection("ModbusSlave"));
            services.AddSingleton(Configuration); 

            services.AddSingleton<IChargerRepository, ChargerRepository>();
            services.AddSingleton<IInverterRepository, InverterRepository>();

            services.AddSingleton<IInverterGaugeService, InverterGaugeService>();

            services.AddSingleton<IHostedService, GatherSolarDataService>();
            // services.AddSingleton<IBackgroundProcess, DataGaugeBackgroundProcess>();
        }

        public void Configure(IApplicationBuilder app, Microsoft.Extensions.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true,
                    ReactHotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMetricServer();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
