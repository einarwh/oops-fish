using System.Collections.Generic;
using System.Linq;

namespace Oops
{
    public class BezierCurveSegment : IShape
    {
        private readonly Point _controlPoint1;
        private readonly Point _controlPoint2;
        private readonly Point _endPoint;

        public BezierCurveSegment(Point controlPoint1, Point controlPoint2, Point endPoint)
        {
            _controlPoint1 = controlPoint1;
            _controlPoint2 = controlPoint2;
            _endPoint = endPoint;
        }

        public IShape Transpose(Box box)
        {
            return new BezierCurveSegment(
                _controlPoint1.Transpose(box), 
                _controlPoint2.Transpose(box),
                _endPoint.Transpose(box));
        }
    }

    public class PathShape : IShape
    {
        private readonly Point _startPoint;
        private readonly IReadOnlyList<BezierCurveSegment> _bezierCurveSegments;

        public PathShape(Point startPoint, IReadOnlyList<BezierCurveSegment> bezierCurveSegments)
        {
            _startPoint = startPoint;
            _bezierCurveSegments = bezierCurveSegments;
        }

        public IShape Transpose(Box box)
        {
            return new PathShape(
                _startPoint.Transpose(box), 
                _bezierCurveSegments
                    .Select(it => it.Transpose(box))
                    .Cast<BezierCurveSegment>()
                    .ToList());
        }
    }

    public class PolygonShape : IShape 
    {
        private readonly IReadOnlyList<Point> _points;

        public PolygonShape(IReadOnlyList<Point> points)
        {
            _points = points;
        }

        public IShape Transpose(Box box)
        {
            return new PolygonShape(_points.Select(it => it.Transpose(box)).ToList());
        }
    }
}