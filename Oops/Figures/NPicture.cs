using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    public class NPicture : FigurePicture
    {
        public NPicture() : base(Shapes) { }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points = new List<Point>
                {
                    new Point(0.30, 0.20),
                    new Point(0.40, 0.20),
                    new Point(0.40, 0.60),
                    new Point(0.60, 0.20),
                    new Point(0.70, 0.20),
                    new Point(0.70, 0.80),
                    new Point(0.60, 0.80),
                    new Point(0.60, 0.40),
                    new Point(0.40, 0.80),
                    new Point(0.30, 0.80)
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