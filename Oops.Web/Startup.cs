using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Oops.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Functional geometry");
                });

                endpoints.MapGet("/fish", FishRequestHandler.GetFish);
                endpoints.MapGet("/fish/ttile", FishRequestHandler.GetTtile);
                endpoints.MapGet("/fish/utile", FishRequestHandler.GetUtile);
                endpoints.MapGet("/fish/side/{depth}", FishRequestHandler.GetSide);
                endpoints.MapGet("/fish/corner/{depth}", FishRequestHandler.GetCorner);
                endpoints.MapGet("/fish/squarelimit/{depth}", FishRequestHandler.GetSquareLimit);
                endpoints.MapGet("/george", GeorgeRequestHandler.GetGeorge);
                endpoints.MapGet("/george/iv", GeorgeRequestHandler.GetGeorgeIV);
                endpoints.MapGet("/george/hifive", GeorgeRequestHandler.GetHiFive);
                endpoints.MapGet("/george/reflection", GeorgeRequestHandler.GetReflection);
            });
        }
    }
}