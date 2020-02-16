using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Oops.Figures;
using Oops.Svg;

namespace Oops.Web
{
    public static class GeorgeRequestHandler
    {
        public static async Task GetGeorge(HttpContext context)
        {
            var box = new Box(
                new Vector(100, 50),
                new Vector(300, 0),
                new Vector(0, 300));

            var george = new GeorgePicture();
            var shapes = george.Render(box);
            var elements = shapes
                .Select(it => it.ToSvgElement())
                .ToArray();

            var svg = new SvgDocument(400, 600, elements);

            context.Response.ContentType = "image/svg+xml";
            await context.Response.WriteAsync(svg.ToString());
        }

        // ReSharper disable once InconsistentNaming
        public static async Task GetGeorgeIV(HttpContext context)
        {
            var box = new Box(
                new Vector(100, 50),
                new Vector(300, 0),
                new Vector(0, 300));

            var george = new GeorgePicture();
            var giv = new QuartetPicture(george, 
                george.Flip().Turn().Turn(), 
                george.Turn().Turn(), 
                george.Flip());

            var shapes = giv.Render(box);
            var elements = shapes
                .Select(it => it.ToSvgElement())
                .ToArray();

            var svg = new SvgDocument(400, 600, elements);

            context.Response.ContentType = "image/svg+xml";
            await context.Response.WriteAsync(svg.ToString());
        }
    }
}