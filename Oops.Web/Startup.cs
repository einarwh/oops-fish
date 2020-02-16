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
                endpoints.MapGet("/fish/side/{n}", FishRequestHandler.GetSide);
                endpoints.MapGet("/fish/corner/{n}", FishRequestHandler.GetCorner);
                endpoints.MapGet("/fish/squarelimit/{n}", FishRequestHandler.GetSquareLimit);
                
                endpoints.MapGet("/george", GeorgeRequestHandler.GetGeorge);
                endpoints.MapGet("/george/iv", GeorgeRequestHandler.GetGeorgeIV);
                endpoints.MapGet("/george/iv/pattern/{n}", GeorgeRequestHandler.GetGeorgeIVPattern);
                endpoints.MapGet("/george/hifive", GeorgeRequestHandler.GetHiFive);
                endpoints.MapGet("/george/hifive/{n}", GeorgeRequestHandler.GetHiFiveRibbon);
                endpoints.MapGet("/george/reflection", GeorgeRequestHandler.GetReflection);

                endpoints.MapGet("/letter/f", LetterRequestHandler.GetF);
                endpoints.MapGet("/letter/h", LetterRequestHandler.GetH);
                endpoints.MapGet("/letter/e", LetterRequestHandler.GetE);
                endpoints.MapGet("/letter/n", LetterRequestHandler.GetN);
                endpoints.MapGet("/letter/d", LetterRequestHandler.GetD);
                endpoints.MapGet("/letter/r", LetterRequestHandler.GetR);
                endpoints.MapGet("/letter/s", LetterRequestHandler.GetS);
                endpoints.MapGet("/letter/o", LetterRequestHandler.GetO);

                endpoints.MapGet("/henderson", LetterRequestHandler.GetName);
                endpoints.MapGet("/henderson/zoom/{n}", LetterRequestHandler.GetNameZoom);
            });
        }
    }
}