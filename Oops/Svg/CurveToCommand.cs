namespace Oops.Svg
{
    public class CurveToCommand : SvgPathCommand
    {
        private readonly SvgPoint _controlPoint1;
        private readonly SvgPoint _controlPoint2;
        private readonly SvgPoint _endPoint;

        public CurveToCommand(SvgPoint controlPoint1,
            SvgPoint controlPoint2,
            SvgPoint endPoint)
        {
            _controlPoint1 = controlPoint1;
            _controlPoint2 = controlPoint2;
            _endPoint = endPoint;
        }

        public override string ToString()
        {
            return $"C {_controlPoint1.ToString(" ")}, {_controlPoint2.ToString(" ")}, {_endPoint.ToString(" ")}";
        }
    }
}