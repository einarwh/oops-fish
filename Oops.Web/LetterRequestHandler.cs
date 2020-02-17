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

        public static Task GetA(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new APicture());
        }

        public static Task GetI(HttpContext context)
        {
            return SvgRequestHandler.GetSvg(context, new IPicture());
        }

        public static Task GetHenderson(HttpContext context)
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

        public static Task GetHendersonZoom(HttpContext context)
        {
            var depthRouteValue = (string)context.GetRouteValue("n");
            var depth = int.Parse(depthRouteValue);

            Picture p = new EPicture();
            for (int i = 0; i < depth; i++)
            {
                p = new ZoomPicture(p);
            }

            return SvgRequestHandler.GetSvg(context, p);
        }

        public static Task GetAstrid(HttpContext context)
        {
            var name = new NonetPicture(
                new APicture(), 
                new SPicture(), 
                new TPicture(), 
                new RPicture(), 
                new IPicture(), 
                new DPicture(), 
                new BlankPicture(), 
                new BlankPicture(), 
                new BlankPicture());

            return SvgRequestHandler.GetSvg(context, name);
        }

        public static Task GetAstri(HttpContext context)
        {
            var name = new NonetPicture(
                new APicture(), 
                new SPicture(), 
                new TPicture(), 
                new RPicture(), 
                new IPicture(), 
                new RPicture().Turn().Turn(), 
                new TPicture().Turn().Turn(), 
                new SPicture().Turn().Turn(), 
                new APicture().Turn().Turn());

            return SvgRequestHandler.GetSvg(context, name);
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