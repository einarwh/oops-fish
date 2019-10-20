using System.Collections.Generic;

namespace Oops
{
    public class PolylineShape : IShape
    {
        private readonly IReadOnlyList<Point> _points;

        public PolylineShape(IReadOnlyList<Point> points)
        {
            _points = points;
        }
    }
}