using System.Collections.Generic;
using System.Linq;
using Oops.Svg;

namespace Oops.Shapes
{
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
                    .ToList());
        }

        private static SvgPoint ConvertPoint(Point pt)
        {
            return new SvgPoint(pt.X(), pt.Y());
        }

        public SvgElement ToSvgElement()
        {
            var commands = new List<SvgPathCommand>
            {
                new MoveToCommand(ConvertPoint(_startPoint))
            };

            commands.AddRange(_bezierCurveSegments
                .Select(it => it.ToCurveToCommand())
                .ToList());

            var result = new PathSvgElement(
                new StrokeSvgAttribute("black"),
                new StrokeWidthSvgAttribute("1"),
                new FillSvgAttribute("None"),
                new DSvgAttribute(commands));

            return result;
        }
    }
}