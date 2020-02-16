using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    public class CornerPicture : Picture
    {
        private readonly Picture _picture;

        public CornerPicture(int n, Picture p)
        {
            _picture = n == 0 
                ? new BlankPicture() 
                : CreateQuartet(n, p);
        }

        private static Picture CreateQuartet(int n, Picture p)
        {
            var s = new SidePicture(n - 1, p);
            var c = new CornerPicture(n - 1, p);
            var u = new UtilePicture(p);
            return new QuartetPicture(c, s, s.Turn(), u);
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box);
        }
    }
}