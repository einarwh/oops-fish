using System.Collections.Generic;
using System.Linq;
using Oops.Svg;

namespace Oops.Shapes
{
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

        public SvgElement ToSvgElement()
        {
            var svgPoints = _points
                .Select(it => new SvgPoint(it.X(), it.Y()))
                .ToList();

            var result = new PolygonSvgElement(
                new StrokeSvgAttribute("black"),
                new StrokeWidthSvgAttribute("1"),
                new FillSvgAttribute("None"),
                new PointsSvgAttribute(svgPoints));

            return result;
        }
    }
}