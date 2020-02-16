using System;
using System.Linq;
using Oops.Figures;
using Oops.Svg;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var b = new Box(
                new Vector(200, 100),
                new Vector(400, 0),
                new Vector(0, 400));
            var g = new GeorgePicture();
            var f = new FPicture();
            var gtt = g.Turn().Turn();
            var ab2 = g.Above(g.Turn().Turn());
            var ab = new AbovePicture(g, gtt);
            var rendering = ab.Render(b);
            var elements = rendering
                .Select(it => it.ToSvgElement())
                .ToList();

            var giv = new QuartetPicture(g,
                g.Flip().Turn().Turn(),
                g.Turn().Turn(),
                g.Flip());

            var sql = new SquareLimitPicture(4, new FishPicture());
            var sqlDoc = new SvgDocument(600, 800, sql.Render(b).Select(it => it.ToSvgElement()).ToList());

            var ssql = sqlDoc.ToString();
            var s = ssql;
        }
    }
}
