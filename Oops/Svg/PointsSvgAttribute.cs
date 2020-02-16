using System.Collections.Generic;
using System.Linq;

namespace Oops.Svg
{
    public class PointsSvgAttribute : SvgAttribute
    {
        public PointsSvgAttribute(IReadOnlyList<SvgPoint> points)
            : base("points", ConvertToString(points)) { }

        private static string ConvertToString(IReadOnlyList<SvgPoint> points)
        {
            return string.Join(" ", 
                points.Select(pt => pt.ToString(",")));
        }
    }
}