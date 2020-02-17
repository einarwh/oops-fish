using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    public class TPicture : FigurePicture
    {
        public TPicture() : base(Shapes) { }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points = new List<Point>
                {
                    new Point(0.45, 0.20),
                    new Point(0.55, 0.20),
                    new Point(0.55, 0.70),
                    new Point(0.70, 0.70),
                    new Point(0.70, 0.80),
                    new Point(0.30, 0.80),
                    new Point(0.30, 0.70),
                    new Point(0.45, 0.70)
                };

                var list = new List<IShape>
                {
                    new PolygonShape(points)
                };
                return list;
            }
        }
    }
}