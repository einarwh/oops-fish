using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    public class BlankPicture : Picture
    {
        public override IReadOnlyList<IShape> Render(Box box)
        {
            return new List<IShape>();
        }
    }
}