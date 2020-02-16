using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    internal class SidePicture : Picture
    {
        private readonly Picture _picture;

        public SidePicture(int n, Picture p)
        {
            _picture = n == 0 ? new BlankPicture() : CreateQuartet(n, p);
        }

        private static Picture CreateQuartet(int n, Picture p)
        {
            var s = new SidePicture(n - 1, p);
            var t = new TtilePicture(p);
            return new QuartetPicture(s, s, t.Turn(), t);
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box);
        }
    }
}