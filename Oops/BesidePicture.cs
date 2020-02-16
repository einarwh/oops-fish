using System.Collections.Generic;
using System.Linq;
using Oops.Shapes;

namespace Oops
{
    internal class BesidePicture : Picture
    {
        private readonly Picture _leftPicture;
        private readonly Picture _rightPicture;
        private readonly double _leftFraction;

        public BesidePicture(Picture leftPicture, Picture rightPicture, double leftWeight, double rightWeight)
        {
            _leftPicture = leftPicture;
            _rightPicture = rightPicture;
            _leftFraction = leftWeight / (leftWeight + rightWeight);
        }

        public BesidePicture(Picture leftPicture, Picture rightPicture)
            : this(leftPicture, rightPicture, 1, 1) { }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            var (leftBox, rightBox) = box.SplitHorizontally(_leftFraction);
            var shapes1 = _leftPicture.Render(leftBox);
            var shapes2 = _rightPicture.Render(rightBox);
            return shapes1.Concat(shapes2).ToList();
        }
    }
}