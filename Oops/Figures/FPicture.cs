using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    internal class FPicture : FigurePicture
    {
        public FPicture() : base(Shapes)
        {
        }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points = new List<Point>
                {
                    new Point(0.30, 0.20),
                    new Point(0.40, 0.20),
                    new Point(0.40, 0.45),
                    new Point(0.60, 0.45),
                    new Point(0.60, 0.55),
                    new Point(0.40, 0.55),
                    new Point(0.40, 0.70),
                    new Point(0.70, 0.70),
                    new Point(0.70, 0.80),
                    new Point(0.30, 0.80)
                };

                var polygon = new PolygonShape(points);

                var list = new List<IShape>
                {
                    polygon
                };
                return list;
            }
        }
    }
}