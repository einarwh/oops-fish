using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Oops.Figures;

namespace Oops.Web
{
    public static class LetterRequestHandler
    {
        public static Task GetF(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new FPicture());
        }

        public static Task GetH(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new HPicture());
        }

        public static Task GetE(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new EPicture());
        }

        public static Task GetN(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new NPicture());
        }

        public static Task GetD(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new DPicture());
        }

        public static Task GetR(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new RPicture());
        }

        public static Task GetS(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new SPicture());
        }

        public static Task GetO(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new OPicture());
        }

        public static Task GetName(HttpContext context)
        {
            var name = new NonetPicture(
                new HPicture(), 
                new EPicture(), 
                new NPicture(), 
                new DPicture(), 
                new EPicture(), 
                new RPicture(), 
                new SPicture(), 
                new OPicture(), 
                new NPicture());

            return SvgRequestHandler.GetSvg(context, name);
        }

        public static Task GetNameZoom(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("n");
            var depth = int.Parse(depthRouteValue);

            Picture p = new BlankPicture();
            for (int i = 0; i < depth; i++)
            {
                p = new ZoomPicture(p);
            }

            return SvgRequestHandler.GetSvg(context, p);
        }

        private class ZoomPicture : NonetPicture
        {
            public ZoomPicture(Picture p)
                : base(new HPicture(),
                    new EPicture(),
                    new NPicture(),
                    new DPicture(),
                    p,
                    new RPicture(),
                    new SPicture(),
                    new OPicture(),
                    new NPicture())
            {}
        }
    }
}