using System.Collections.Generic;
using System.Linq;
using Oops.Shapes;

namespace Oops
{
    public abstract class FigurePicture : Picture
    {
        private readonly IReadOnlyList<IShape> _shapes;

        protected FigurePicture(IReadOnlyList<IShape> shapes)
        {
            _shapes = shapes;
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _shapes.Select(it => it.Transpose(box)).ToList();
        }
    }
}