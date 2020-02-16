using System.Collections.Generic;
using Oops.Shapes;

namespace Oops.Figures
{
    internal class FishPicture : FigurePicture
    {
        public FishPicture() : base(Shapes)
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

                var polyline = new PolylineShape(points);

                var list = new List<IShape>
                {
                    polyline
                };
                return list;
            }
        }

    }
}