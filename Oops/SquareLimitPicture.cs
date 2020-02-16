using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    internal class SquareLimitPicture : Picture
    {
        private readonly NonetPicture _picture;

        public SquareLimitPicture(int n, Picture p)
        {
            var nw = new CornerPicture(n, p);
            var sw = nw.Turn();
            var se = sw.Turn();
            var ne = se.Turn();
            var nm = new SidePicture(n, p);
            var mw = nm.Turn();
            var sm = mw.Turn();
            var me = sm.Turn();
            var mm = new UtilePicture(p);
            _picture = new NonetPicture(nw, nm, ne, mw, mm, me, sw, sm, se);
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box);
        }
    }
}