using CoreDeneme.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using CoreDeneme.Entity;
using CoreDeneme.Repositories;
using Microsoft.OpenApi.Models;
using CoreDeneme.Abstract;
using CoreDeneme.RabbitMqService;
using CoreDeneme.Data;

namespace CoreDeneme
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
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DevConnection"));
            });
            
            // servisin ismi ve servisin implement edildiði sýnýfý yazýyoruz ve bize onun nesnesini oluþturuyor
            services.AddScoped<IProfileRepository, ProfileRepository>();

            //services.AddScoped(typeof(IRepository<>),typeof(GenericRepository<>));
            services.AddScoped<IRabbitMqService, RabbitMq>();
            services.AddScoped<IRabbitMqConfiguration, RabbitMqConfiguration>();
            services.AddScoped<IObjectConvertFormat, ObjectConvertFormatManager>();
            services.AddScoped<IDataModel<User>, UsersDataModel>();
            services.AddScoped<ISmtpConfiguration, SmtpConfiguration>();
            services.AddScoped<IPublisherService, PublisherManager>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });
        }

    }
}
