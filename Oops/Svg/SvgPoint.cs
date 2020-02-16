using System.Globalization;

namespace Oops.Svg
{
    public class SvgPoint
    {
        private readonly double _x;
        private readonly double _y;

        public SvgPoint(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return ToString(",");
        }

        public string ToString(string separator)
        {
            return $"{ToString(_x)}{separator}{ToString(_y)}";
        }

        private static string ToString(double d)
        {
            return d.ToString("0.###", CultureInfo.InvariantCulture);
        }
    }
}