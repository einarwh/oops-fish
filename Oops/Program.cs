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
                new Vector(50, 50),
                new Vector(300, 0),
                new Vector(0, 300));
            var g = new GeorgePicture();
            var f = new FPicture();
            var gtt = g.Turn().Turn();
            var ab2 = g.Above(g.Turn().Turn());
            var ab = new AbovePicture(g, gtt);
            var rendering = ab.Render(b);
            var elements = rendering
                .Select(it => it.ToSvgElement())
                .ToList();

            var doc = new SvgDocument(400, 400, elements);
            var str = doc.ToString();

            var giv = new QuartetPicture(g,
                g.Flip().Turn().Turn(),
                g.Turn().Turn(),
                g.Flip());

            var sql = new SquareLimitPicture(5, new FishPicture());
        }
    }
}
