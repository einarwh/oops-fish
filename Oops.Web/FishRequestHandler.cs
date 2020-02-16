using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Oops.Figures;

namespace Oops.Web
{
    public static class FishRequestHandler
    {
        public static Task GetFish(HttpContext context)
        {
            var fish = new FishPicture();
            return SvgRequestHandler.GetSvg(context, fish);
        }

        public static Task GetTtile(HttpContext context)
        {
            var fish = new FishPicture();
            var ttile = new TtilePicture(fish);
            return SvgRequestHandler.GetSvg(context, ttile);
        }

        public static Task GetUtile(HttpContext context)
        {
            var fish = new FishPicture();
            var utile = new UtilePicture(fish);
            return SvgRequestHandler.GetSvg(context, utile);
        }

        public static Task GetSide(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("depth");
            var depth = int.Parse(depthRouteValue);

            var fish = new FishPicture();
            var side = new SidePicture(depth, fish);
            return SvgRequestHandler.GetSvg(context, side);
        }

        public static Task GetCorner(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("depth");
            var depth = int.Parse(depthRouteValue);

            var fish = new FishPicture();
            var corner = new CornerPicture(depth, fish);
            return SvgRequestHandler.GetSvg(context, corner);
        }

        public static Task GetSquareLimit(HttpContext context)
        {
            var depthRouteValue = (string) context.GetRouteValue("depth");
            var depth = int.Parse(depthRouteValue);

            var fish = new FishPicture();
            var squareLimit = new SquareLimitPicture(depth, fish);
            return SvgRequestHandler.GetSvg(context, squareLimit);
        }
    }
}