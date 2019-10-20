using System.Collections.Generic;
using System.Linq;

namespace Oops
{
    public class PolylineShape : IShape
    {
        private readonly IReadOnlyList<Point> _points;

        public PolylineShape(IReadOnlyList<Point> points)
        {
            _points = points;
        }

        public IShape Transpose(Box box)
        {
            return new PolylineShape(_points.Select(it => it.Transpose(box)).ToList());
        }
    }
}