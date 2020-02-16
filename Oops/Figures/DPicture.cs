using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    public class DPicture : FigurePicture
    {
        public DPicture() : base(Shapes) { }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points1 = new List<Point>
                {
                    new Point(0.30, 0.20),
                    new Point(0.55, 0.20),
                    new Point(0.70, 0.35),
                    new Point(0.70, 0.65),
                    new Point(0.55, 0.80),
                    new Point(0.30, 0.80)
                };

                var points2 = new List<Point>
                {
                    new Point(0.40, 0.30),
                    new Point(0.52, 0.30),
                    new Point(0.60, 0.38),
                    new Point(0.60, 0.62),
                    new Point(0.52, 0.70),
                    new Point(0.40, 0.70)
                };

                var list = new List<IShape>
                {
                    new PolygonShape(points1),
                    new PolygonShape(points2)
                };
                return list;
            }
        }
    }
}