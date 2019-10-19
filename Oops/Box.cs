using System;

namespace Oops
{
    public class Box : IEquatable<Box>
    {
        private readonly Vector _a;
        private readonly Vector _b;
        private readonly Vector _c;

        public Box(Vector a, Vector b, Vector c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public Box Turn()
        {
            return new Box(_a.Add(_b), _c, _b.Negate());
        }

        public Box Flip()
        {
            return new Box(_a.Add(_b), _b.Negate(), _c);
        }

        public Box Toss()
        {
            return new Box(_a.Add(_b.Add(_c).Scale(0.5)), _b.Add(_c).Scale(0.5), _c.Subtract(_b).Scale(0.5));
        }

        private Box MoveVertically(double fraction)
        {
            return new Box(_a.Add(_c.Scale(fraction)), _b, _c);
        }

        private Box ScaleVertically(double fraction)
        {
            return new Box(_a, _b, _c.Scale(fraction));
        }

        public (Box, Box) SplitVertically(double topFraction)
        {
            var top = MoveVertically(1 - topFraction).ScaleVertically(topFraction);
            var bot = ScaleVertically(1 - topFraction);
            return (top, bot);
        }

        private Box MoveHorizontally(double fraction)
        {
            return new Box(_a.Add(_b.Scale(fraction)), _b, _c);
        }

        private Box ScaleHorizontally(double fraction)
        {
            return new Box(_a, _b.Scale(fraction), _c);
        }

        public (Box, Box) SplitHorizontally(double leftFraction)
        {
            var left = ScaleHorizontally(leftFraction);
            var right = MoveHorizontally(leftFraction).ScaleHorizontally(1 - leftFraction);
            return (left, right);
        }

        public bool Equals(Box other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_a, other._a) && Equals(_b, other._b) && Equals(_c, other._c);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Box) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_a != null ? _a.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_b != null ? _b.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_c != null ? _c.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(Box left, Box right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Box left, Box right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"Box [a: {_a}, b: {_b}, c: {_c}]";
        }
    }
}