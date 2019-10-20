using System.Collections.Generic;

namespace Oops
{
    internal class TossedPicture : Picture
    {
        private readonly Picture _picture;

        public TossedPicture(Picture picture)
        {
            _picture = picture;
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box.Turn());
        }
    }
}