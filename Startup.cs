using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace BookStoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false)
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
                        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // bu metod ilewwwroot klasörü tarayıcıya erişimi açılmış oldu

            app.UseStaticFiles(new StaticFileOptions { //root dışında herhangi bir klasörü dışarı açmak için gerekli olan işlem
                
                FileProvider = new PhysicalFileProvider(Path.Combine 
                (Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath = "/modules"

            });

            //modules/bootstrap/dist/css/bootstrap.min.cs
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseRouting();

            app.UseMvcWithDefaultRoute();




        }
    }
}
