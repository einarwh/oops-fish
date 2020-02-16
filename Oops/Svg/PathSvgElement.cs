namespace Oops.Svg
{
    public class PathSvgElement : SvgElement
    {
        public PathSvgElement(params SvgAttribute[] attributes)
            : base("path", attributes)
        {
        }
    }
}