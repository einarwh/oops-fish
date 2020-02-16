using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Oops.Svg;

namespace Oops.Web
{
    public static class SvgRequestHandler
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