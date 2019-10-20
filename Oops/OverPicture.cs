using System.Collections.Generic;
using System.Linq;

namespace Oops
{
    internal class OverPicture : Picture
    {
        private readonly Picture _p1;
        private readonly Picture _p2;

        public OverPicture(Picture p1, Picture p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            var shapes1 = _p1.Render(box);
            var shapes2 = _p2.Render(box);
            return shapes1.Concat(shapes2).ToList();
        }
    }
}