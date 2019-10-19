namespace Oops
{
    internal class Vector
    {
        private readonly double _x;
        private readonly double _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Vector Add(Vector v)
        {
            return new Vector(_x + v._x, _y + v._y);
        }

        public Vector Negate()
        {
            return new Vector(-_x, -_y);
        }

        public Vector Subtract(Vector v)
        {
            return new Vector(_x - v._x, _y - v._y);
        }

        public Vector Scale(double factor)
        {
            return new Vector(_x * factor, _y * factor);
        }
    }
}