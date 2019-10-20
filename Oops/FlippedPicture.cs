using System.Collections.Generic;

namespace Oops
{
    internal class FlippedPicture : Picture
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