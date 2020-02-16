using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            var above = new BesidePicture(george.Flip(),
                george);

            return SvgRequestHandler.GetSvg(context, above);
        }

    }
}