namespace Oops.Svg
{
    public class MoveToCommand : SvgPathCommand
    {
        private readonly SvgPoint _point;

        public MoveToCommand(SvgPoint point)
        {
            _point = point;
        }

        public override string ToString()
        {
            return $"M {_point}";
        }
    }
}