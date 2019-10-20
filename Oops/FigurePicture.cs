using System.Collections.Generic;
using System.Linq;

namespace Oops
{
    internal class FigurePicture : Picture
    {
        private readonly IFigure _figure;

        public FigurePicture(IFigure figure)
        {
            _figure = figure;
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _figure.Shapes.Select(it => it.Transpose(box)).ToList();
        }
    }
}