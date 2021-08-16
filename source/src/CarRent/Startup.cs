using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;
using CarRent.CarManagement.Infrastructure.Persistence;
using CarRent.Common.Infrastructure.Context;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Domain;
using CarRent.CustomerManagement.Infrastructure.Persistance;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Domain;
using CarRent.ReservationManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarRent
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
            services.AddDbContext<CarRentDbContext>(config =>
            {
                config.UseSqlServer(Configuration.GetConnectionString("baseConnection"));
            });

            services.AddTransient<ICustomerService, CustomerService>();
            services.AddScoped<IRepository<Customer, Guid>, CustomerRepository>();

            services.AddTransient<IPlzService, PlzService>();
            services.AddScoped<IRepository<Plz, Guid>, PlzRepository>();

            services.AddTransient<ICarService, CarService>();
            services.AddScoped<IRepository<Car, Guid>, CarRepository>();

            services.AddTransient<IClassService, ClassService>();
            services.AddScoped<IRepository<Class, Guid>, ClassRepository>();

            services.AddTransient<IReservationService, ReservationService>();
            services.AddScoped<IRepository<Reservation, Guid>, ReservationRepository>();

            services.AddAutoMapper(typeof(Car), typeof(Customer), typeof(Reservation));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarRent", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarRent v1"));
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
