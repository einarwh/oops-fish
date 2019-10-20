using System.Collections.Generic;

namespace Oops
{
    internal class TtilePicture : Picture
    {
        private readonly Picture _ttile;

        public TtilePicture(Picture p)
        {
            var n = p.Toss().Flip();
            var e = n.Turn().Turn().Turn();
            _ttile = p.Over(n).Over(e);
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _ttile.Render(box);
        }
    }
}