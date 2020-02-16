using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    internal class UtilePicture : Picture
    {
        private readonly Picture _utile;

        public UtilePicture(Picture p)
        {
            var n = p.Toss().Flip();
            var w = n.Turn();
            var s = w.Turn();
            var e = s.Turn();
            _utile = n.Over(w).Over(s).Over(e);
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _utile.Render(box);
        }
    }
}