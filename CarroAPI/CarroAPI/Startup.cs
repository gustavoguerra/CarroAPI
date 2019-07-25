using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarroAPI.Business;
using CarroAPI.Domain;
using CarroAPI.Repository;
using CarroAPI.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CarroAPI
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
            DependencyInjection(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void DependencyInjection(IServiceCollection services)
        {
            // Mantem na memoria todo o tempo da requisição <Gasta mais memoria porem mais rapido>
            //services.AddSingleton<IRepository<Carro>, Repository<Carro>>();
            //services.AddScoped<CarroServices>();
            //services.AddScoped<CarroBusiness>();
            //services.AddScoped<Carro>();
            
            // Cria uma nova a cada requisição <Economisa memoria porem mais lento>
            services.AddSingleton<IRepository<Carro>, Repository<Carro>>();
            services.AddTransient<CarroServices>();
            services.AddTransient<CarroBusiness>();
            services.AddTransient<Carro>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
