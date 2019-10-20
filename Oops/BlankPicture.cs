using System.Collections.Generic;

namespace Oops
{
    internal class BlankPicture : Picture
    {
        public override IReadOnlyList<IShape> Render(Box box)
        {
            return new List<IShape>();
        }
    }
}