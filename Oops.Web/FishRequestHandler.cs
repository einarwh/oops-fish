using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Oops.Figures;
using Oops.Svg;

namespace Oops.Web
{
    public static class FishRequestHandler
    {
        public static async Task GetFish(HttpContext context)
        {
            var box = new Box(
                new Vector(100, 50),
                new Vector(300, 0),
                new Vector(0, 300));

            var fish = new FishPicture();
            var shapes = fish.Render(box);
            var elements = shapes
                .Select(it => it.ToSvgElement())
                .ToArray();

            var svg = new SvgDocument(400, 600, elements);

            context.Response.ContentType = "image/svg+xml";
            await context.Response.WriteAsync(svg.ToString());
        }

        public static async Task GetSquareLimit(HttpContext context, int depth)
        {
            var box = new Box(
                new Vector(100, 50),
                new Vector(300, 0),
                new Vector(0, 300));

            var fish = new FishPicture();
            var sql = new SquareLimitPicture(depth, fish);
            var shapes = sql.Render(box);
            var elements = shapes
                .Select(it => it.ToSvgElement())
                .ToArray();

            var svg = new SvgDocument(400, 600, elements);

            context.Response.ContentType = "image/svg+xml";
            await context.Response.WriteAsync(svg.ToString());
        }
    }
}