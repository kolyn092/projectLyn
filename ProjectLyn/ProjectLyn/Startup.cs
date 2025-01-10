using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServerLib;
using System.Text;

namespace ProjectLyn
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            Logger.Default.LogDebug("Start ConfigureServices");
            var mvcBuilder = services.AddMvc();
            mvcBuilder.Services.AddRazorPages();

            Logger.Default.LogDebug("Finished ConfigureServices");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseExceptionHandler(errorApp =>
            //{
            //    errorApp.Run(async context =>
            //    {
            //        context.Response.StatusCode = 500;
            //        context.Response.ContentType = "application/json";


            //        var exceptionHandlerPathFeature =
            //            context.Features.Get<IExceptionHandlerPathFeature>();

            //        // Use exceptionHandlerPathFeature to process the exception (for example, 
            //        // logging), but do NOT expose sensitive error information directly to 
            //        // the client.
            //        if (exceptionHandlerPathFeature != null)
            //        {
            //            var error = exceptionHandlerPathFeature.Error.ToString();
            //            Logger.Default.LogError(error);
            //            var xmlBytes = Encoding.ASCII.GetBytes(error);
            //            await context.Response.Body.WriteAsync(xmlBytes);
            //        }
            //    });
            //});

            // The default HSTS value is 30 days. You may want to change this production scenarios.
            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(); //web
            app.UseAuthorization();
        }
    }
}
