using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Oops.Figures;
using Oops.Svg;

namespace Oops.Web
{
    public static class FishRequestHandler
    {
        private static IEnumerable<string> GetQueryParameters(QueryString qs)
        {
            return qs.HasValue 
                ? GetQueryParameters(qs.Value) 
                : new string[0];
        }

        private static IEnumerable<string> GetQueryParameters(string queryString)
        {
            return queryString.Substring(1).Split("&");
        }

        public static Task GetFish(HttpContext context)
        {
            var fish = new FishPicture();
            return GetSvg(context, fish);
        }

        public static Task GetTtile(HttpContext context)
        {
            var fish = new FishPicture();
            var ttile = new TtilePicture(fish);
            return GetSvg(context, ttile);
        }

        public static Task GetUtile(HttpContext context)
        {
            var fish = new FishPicture();
            var utile = new UtilePicture(fish);
            return GetSvg(context, utile);
        }

        public static Task GetSide(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("depth");
            var depth = int.Parse(depthRouteValue);

            var fish = new FishPicture();
            var side = new SidePicture(depth, fish);
            return GetSvg(context, side);
        }

        public static Task GetCorner(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("depth");
            var depth = int.Parse(depthRouteValue);

            var fish = new FishPicture();
            var corner = new CornerPicture(depth, fish);
            return GetSvg(context, corner);
        }

        public static Task GetSquareLimit(HttpContext context)
        {
            var depthRouteValue = (string) context.GetRouteValue("depth");
            var depth = int.Parse(depthRouteValue);

            var fish = new FishPicture();
            var squareLimit = new SquareLimitPicture(depth, fish);
            return GetSvg(context, squareLimit);
        }

        public static async Task GetSvg(HttpContext context, Picture picture)
        {
            var queryParams = GetQueryParameters(context.Request.QueryString);

            var box = new Box(
                new Vector(100, 50),
                new Vector(300, 0),
                new Vector(0, 300));

            var shapes = picture
                .Decorate(queryParams)
                .Render(box);

            var elements = shapes
                .Select(it => it.ToSvgElement())
                .ToArray();

            var svg = new SvgDocument(400, 600, elements);

            context.Response.ContentType = "image/svg+xml";
            await context.Response.WriteAsync(svg.ToString());
        }
    }
}