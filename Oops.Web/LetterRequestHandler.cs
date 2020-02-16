using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Oops.Figures;

namespace Oops.Web
{
    public static class LetterRequestHandler
    {
        public static Task GetF(HttpContext context)
        {
            var f = new FPicture();
            return SvgRequestHandler.GetSvg(context, f);
        }

        public static Task GetH(HttpContext context)
        {
            var h = new HPicture();
            return SvgRequestHandler.GetSvg(context, h);
        }

    }
}