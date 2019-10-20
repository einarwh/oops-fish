using System.Collections.Generic;

namespace Oops
{
    public class PolygonShape : IShape 
    {
        private readonly IReadOnlyList<Point> _points;

        public PolygonShape(IReadOnlyList<Point> points)
        {
            _points = points;
        }
    }
}