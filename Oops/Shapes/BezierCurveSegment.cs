using Oops.Svg;

namespace Oops.Shapes
{
    public class BezierCurveSegment 
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

        public BezierCurveSegment Transpose(Box box)
        {
            return new BezierCurveSegment(
                _controlPoint1.Transpose(box), 
                _controlPoint2.Transpose(box),
                _endPoint.Transpose(box));
        }

        private static SvgPoint ConvertPoint(Point pt)
        {
            return new SvgPoint(pt.X(), pt.Y());
        }

        public CurveToCommand ToCurveToCommand()
        {
            return new CurveToCommand(ConvertPoint(_controlPoint1),
                ConvertPoint(_controlPoint2),
                ConvertPoint(_endPoint));
        }
    }
}