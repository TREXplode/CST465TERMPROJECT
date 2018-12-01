using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lab5CST465
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            services.Configure<TreatersSettings>(configuration);
            //services.AddTransient<ITreater, TreaterDB>();
            services.AddTransient<ITreater, TreaterJsonRep>();
            //services.AddTransient<ICandy, CandyDB>();
            services.AddTransient<ICandy, CandyJsonRep>();
            //services.AddTransient<ICostume, CostumeDB>();
            services.AddTransient<ICostume, CostumeJsonRep>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Index");
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            string baseDir = env.ContentRootPath;
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(baseDir, "App_Data"));

            //System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Costume.json");
        }
    }
}
