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

        public override void Render(Box box)
        {
            var (leftBox, rightBox) = box.SplitHorizontally(_leftFraction);
            _leftPicture.Render(leftBox);
            _rightPicture.Render(rightBox);
        }
    }
}