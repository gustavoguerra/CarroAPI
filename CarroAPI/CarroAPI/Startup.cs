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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(CarroServices));
            services.AddScoped(typeof(CarroBusiness));
            services.AddScoped(typeof(Carro));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        //public void DependencyInjection(IServiceCollection services)
        //{
        //    services.AddTransient<CarroServices>();
        //    services.AddTransient<CarroBusiness>();
        //    services.AddSingleton<IRepository<Carro>, Repository<Carro>>();
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
