using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADM.PruebaTecnica.Data;
using ADM.PruebaTecnica.Repository.Implementaciones;
using ADM.PruebaTecnica.Repository.Interfaces;
using ADM.PruebaTecnica.Services.Domain;
using ADM.PruebaTecnica.Services.Implementaciones;
using ADM.PruebaTecnica.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ADM.PruebaTecnica.Api
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
            services.AddSingleton<IConfiguration>(provider => Configuration);
            services.AddDbContext<ADMDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MDF")));
            services.AddScoped<ICategoriasService, CategoriasService>();
            services.AddScoped<ICategoriasRepository, CategoriaRepository>();
            services.AddScoped<IAlgortimosDomain, AlgortimosDomain>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
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

            app.UseCors(builder =>
                   builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
