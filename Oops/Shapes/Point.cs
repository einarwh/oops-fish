using System;

namespace Oops.Shapes
{
    public class Point : IEquatable<Point>
    {
        private readonly double _x;
        private readonly double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X()
        {
            return _x;
        }

        public double Y()
        {
            return _y;
        }

        public Point Displace(Vector v)
        {
            return new Point(_x + v.X(), _y + v.Y());
        }

        public Point Transpose(Box box)
        {
            return new Point(0, 0) + box.A() + _x * box.B() + _y * box.C();
        }

        public static Point operator +(Point p, Vector v)
        {
            return p.Displace(v);
        }

        public override string ToString()
        {
            return $"Point ({_x}, {_y})";
        }

        public bool Equals(Point other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _x.Equals(other._x) && _y.Equals(other._y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_x.GetHashCode() * 397) ^ _y.GetHashCode();
            }
        }

        public static bool operator ==(Point left, Point right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !Equals(left, right);
        }
    }
}