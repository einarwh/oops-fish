using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    public class SPicture : FigurePicture
    {
        public SPicture() : base(Shapes) { }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points = new List<Point>
                {
                    new Point(0.30, 0.20),
                    new Point(0.70, 0.20),
                    new Point(0.70, 0.55),
                    new Point(0.40, 0.55),
                    new Point(0.40, 0.70),
                    new Point(0.70, 0.70),
                    new Point(0.70, 0.80),
                    new Point(0.30, 0.80),
                    new Point(0.30, 0.45),
                    new Point(0.60, 0.45),
                    new Point(0.60, 0.30),
                    new Point(0.30, 0.30)
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