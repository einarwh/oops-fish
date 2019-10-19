using System;

namespace Oops
{
    public class Vector : IEquatable<Vector>
    {
        private readonly double _x;
        private readonly double _y;

        public Vector(double x, double y)
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

        public static Vector operator +(Vector v1, Vector v2)
        {
            return v1.Add(v2);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return v1.Subtract(v2);
        }

        public static Vector operator -(Vector v)
        {
            return v.Negate();
        }

        public static Vector operator *(Vector v, double f)
        {
            return v.Scale(f);
        }

        public static Vector operator *(double f, Vector v)
        {
            return v.Scale(f);
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

        public override string ToString()
        {
            return $"Vector ({_x}, {_y})";
        }

        public bool Equals(Vector other)
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
            return Equals((Vector) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_x.GetHashCode() * 397) ^ _y.GetHashCode();
            }
        }

        public static bool operator ==(Vector left, Vector right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vector left, Vector right)
        {
            return !Equals(left, right);
        }
    }
}