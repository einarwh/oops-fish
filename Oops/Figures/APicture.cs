using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    public class APicture : FigurePicture
    {
        public APicture() : base(Shapes) { }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points1 = new List<Point>
                {
                    new Point(0.30, 0.20),
                    new Point(0.40, 0.20),
                    new Point(0.40, 0.45),
                    new Point(0.60, 0.45),
                    new Point(0.60, 0.20),
                    new Point(0.70, 0.20),
                    new Point(0.70, 0.80),
                    new Point(0.40, 0.80),
                    new Point(0.30, 0.80)
                };

                var points2 = new List<Point>
                {
                    new Point(0.40, 0.55),
                    new Point(0.60, 0.55),
                    new Point(0.60, 0.70),
                    new Point(0.40, 0.70)
                };

                var list = new List<IShape>
                {
                    new PolygonShape(points1),
                    new PolygonShape(points2)
                };
                return list;            }
        }
    }
}