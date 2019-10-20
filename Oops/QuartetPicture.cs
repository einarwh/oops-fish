using System.Collections.Generic;

namespace Oops
{
    internal class QuartetPicture : Picture
    {
        private readonly Picture _picture;

        public QuartetPicture(Picture nw, Picture ne, Picture sw, Picture se)
        {
            _picture = new AbovePicture(
                new BesidePicture(nw, ne), 
                new BesidePicture(sw, se));
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _picture.Render(box);
        }
    }
}