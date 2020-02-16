using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    public class GeorgePicture : FigurePicture
    {
        public GeorgePicture() : base(Shapes)
        {
        }

        private static IReadOnlyList<IShape> Shapes
        {
            get
            {
                var points1 = new List<Point>
                {
                    new Point(0.00, 0.55),
                    new Point(0.15, 0.45),
                    new Point(0.30, 0.55),
                    new Point(0.40, 0.50),
                    new Point(0.20, 0.00)
                };

                var points2 = new List<Point>
                {
                    new Point(0.00, 0.80),
                    new Point(0.15, 0.60),
                    new Point(0.30, 0.65),
                    new Point(0.40, 0.65),
                    new Point(0.35, 0.80),
                    new Point(0.40, 1.00)
                };

                var points3 = new List<Point>
                {
                    new Point(0.60, 1.00),
                    new Point(0.65, 0.80),
                    new Point(0.60, 0.65),
                    new Point(0.80, 0.65),
                    new Point(1.00, 0.45)
                };

                var points4 = new List<Point>
                {
                    new Point(1.00, 0.20),
                    new Point(0.60, 0.50),
                    new Point(0.80, 0.00)
                };

                var points5 = new List<Point>
                {
                    new Point(0.40, 0.00),
                    new Point(0.50, 0.30),
                    new Point(0.60, 0.00)
                };

                var list = new List<IShape>
                {
                    new PolylineShape(points1),
                    new PolylineShape(points2),
                    new PolylineShape(points3),
                    new PolylineShape(points4),
                    new PolylineShape(points5)
                };
                return list;
            }
        }
    }
}