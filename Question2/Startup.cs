using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Question2.Interfaces;
using Question2.Repo.Data;
using Question2.Repo.Service;
using Question2.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
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
            services.AddDbContext<Question2Context>(x => x.UseInMemoryDatabase(databaseName: "InMemoryDb"));
            services.AddScoped<Question2Context>();
            services.AddScoped<IDetailsService, DetailsService>();
            services.AddScoped<IDetailsRepo, DetailsRepo>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "CoureTech Test API",
                    Version = "v2",
                    Description = "Technical Assessment",
                });
                // define swagger docs and other options
                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "Enter JWT Bearer authorisation token",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer", // must be lowercase!!!
                    BearerFormat = "Bearer {token}",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };
                options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, securityScheme);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                { { securityScheme, Array.Empty<string>() }
                        });
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
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v2/swagger.json", "CoureTech Test"));
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

