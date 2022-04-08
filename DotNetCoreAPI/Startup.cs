using Azure.Data.Tables;
using DotNetCoreAPI.Common.AppSettings;
using DotNetCoreAPI.Common.Interface;
using DotNetCoreAPI.Data.Resource;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotnetCoreAPI.Service
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
            #region Context Configuration
           

            #endregion

            services.AddControllers();

            services.AddSwaggerGen();

            services.AddMvc().AddFluentValidation();

            var connectionString = Configuration.GetConnectionString("CosmosTableApi");
            services.AddSingleton<TableClient>(new TableClient(connectionString, "IntegrationData"));
            services.AddSingleton<TableStorageContext>();


            #region Injection registration
            services.AddTransient<IAppSettingsService, AppServiceSettings>();

            // Register Repositories
            

            // Register Engines

            
            // Register validators
            
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI();
            
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
