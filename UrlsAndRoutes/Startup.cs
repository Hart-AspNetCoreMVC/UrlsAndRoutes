using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace UrlsAndRoutes
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>

            {   //contraint -- if there are 3 segs then the last must be betw 1900 and 2020, inclusive
                routes.MapRoute("", "{controller=Home}/{action=Index}/{id:range(1900,2020)}");
                //catch all route, any extra portion will be saved under var id
//                routes.MapRoute("", "{controller=Home}/{action=Index}/{*id}");
                //will match nothing, any controller alone, any controller and action, or all 3; the id can be passed to param to use in ctlr
//                routes.MapRoute("", "{controller=Home}/{action=Index}/{id=Default}");
                
                //specifically defines where a URL should go in the defaults property
                routes.MapRoute("", "foo/bar", defaults: new {controller = "customer", action = "list"});
                
                
                //must have 2 segments starting with x since no defaults declared; xcontroller and x alone will not work
                routes.MapRoute("", "X{controller}/{action}");
                //maps to nothing and uses defaults or to index of specified controller if action is left off, or the specifies controller and action
                routes.MapRoute("", "{controller=home}/{action=Index}");
//                accepts public alone or with a specified controller if index left off, or public with specified controller and index
                routes.MapRoute("", "Public/{controller=home}/{action=index}");
                

            });
        }
    }
}
