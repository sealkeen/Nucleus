using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Nucleus.Web.Api
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
            RegisterControllers(services);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nucleus.Web.Api", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nucleus.Web.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        #region private methods

        private static void RegisterControllers(IServiceCollection services)
        {
            var mvcBuilder = services.AddControllers();
            LoadModules(mvcBuilder);
        }

        private static void LoadModules(IMvcBuilder mvcBuilder)
        {
            var moduleAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a =>
                {
                    var name = a.GetName().Name;
                    return name != null && name.Contains("Nucleus.Modules");
                });

            foreach (var moduleAssembly in moduleAssemblies)
            {
                mvcBuilder.AddApplicationPart(moduleAssembly);
            }
        }

        #endregion
    }
}
