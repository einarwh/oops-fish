using Oops.Svg;

namespace Oops.Shapes
{
    public interface IShape
    {
        IShape Transpose(Box box);

        SvgElement ToSvgElement();
    }
}