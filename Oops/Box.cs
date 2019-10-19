namespace Oops
{
    internal class Box
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
    }
}