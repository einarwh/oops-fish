namespace Oops
{
    internal class AbovePicture : Picture
    {
        private readonly Picture _topPicture;
        private readonly Picture _bottomPicture;
        private readonly double _topFraction;

        public AbovePicture(Picture topPicture, Picture bottomPicture, double topWeight, double bottomWeight)
        {
            _topPicture = topPicture;
            _bottomPicture = bottomPicture;
            _topFraction = topWeight / (topWeight + bottomWeight);
        }

        public AbovePicture(Picture topPicture, Picture bottomPicture) 
            : this(topPicture, bottomPicture, 1, 1) { }

        public override void Render(Box box)
        {
            var (topBox, bottomBox) = box.SplitVertically(_topFraction);
            _topPicture.Render(topBox);
            _bottomPicture.Render(bottomBox);
        }
    }
}