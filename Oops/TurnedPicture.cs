using System.Collections.Generic;

namespace Oops
{
    internal class TurnedPicture : Picture
    {
        private readonly Picture _picture;

        public TurnedPicture(Picture picture)
        {
            _picture = picture;
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box.Turn());
        }
    }
}