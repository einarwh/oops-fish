using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Oops.Figures;

namespace Oops.Web
{
    public static class GeorgeRequestHandler
    {
        public static Task GetGeorge(HttpContext context)
        {
            var george = new GeorgePicture();
            return SvgRequestHandler.GetSvg(context, george);
        }

        // ReSharper disable once InconsistentNaming
        public static Task GetGeorgeIV(HttpContext context)
        {
            var george = new GeorgePicture();
            var giv = new QuartetPicture(george, 
                george.Flip().Turn().Turn(), 
                george.Turn().Turn(), 
                george.Flip());

            return SvgRequestHandler.GetSvg(context, giv);
        }

        public static Task GetReflection(HttpContext context)
        {
            var george = new GeorgePicture();
            var above = new AbovePicture(george,
                george.Turn().Turn());

            return SvgRequestHandler.GetSvg(context, above);
        }

        public static Task GetHiFive(HttpContext context)
        {
            var george = new GeorgePicture();
            var hiFive = new BesidePicture(george.Flip(),
                george);

            return SvgRequestHandler.GetSvg(context, hiFive);
        }

        public static Task GetGeorgeIVPattern(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("n");
            var depth = int.Parse(depthRouteValue);

            var george = new GeorgePicture();
            var giv = new QuartetPicture(george,
                george.Flip().Turn().Turn(),
                george.Turn().Turn(),
                george.Flip());

            Picture p = giv;
            for (int i = 0; i < depth; i++)
            {
                p = new Q4Picture(p);
            }
            
            return SvgRequestHandler.GetSvg(context, p);
        }


        public static Task GetHiFiveRibbon(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("n");
            var depth = int.Parse(depthRouteValue);

            var george = new GeorgePicture();
            var hiFive = new BesidePicture(george.Flip(), george);

            Picture p = hiFive;
            for (int i = 1; i < depth; i++)
            {
                p = new BesidePicture(p, p);
            }

            return SvgRequestHandler.GetSvg(context, p);
        }

        private class Q4Picture : QuartetPicture
        {
            public Q4Picture(Picture p)
                : base(p, p, p, p)
            {
            }
        }
    }
}