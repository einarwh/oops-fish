using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    public class FlippedPicture : Picture
    {
        private readonly Picture _picture;

        public FlippedPicture(Picture picture)
        {
            _picture = picture;
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box.Flip());
        }
    }
}