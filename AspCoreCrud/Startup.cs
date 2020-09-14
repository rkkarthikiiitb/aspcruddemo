using System.Text.Json.Serialization;
using AspCoreCrud.CoreInterfaces;
using AspCoreCrud.Mapper;
using AspCoreCrud.model;
using AspCoreCrud.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace AspCoreCrud
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
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapProfile());
            });
            services.AddSingleton(mappingConfig.CreateMapper());
            services.AddScoped<IVehicleRepository<Car>, CarRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllersWithViews();
            services.AddControllers();
            services.AddDbContext<VehicleManagementDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
