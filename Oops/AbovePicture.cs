using System.Collections.Generic;
using System.Linq;

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

        public override IReadOnlyList<IShape> Render(Box box)
        {
            var (topBox, bottomBox) = box.SplitVertically(_topFraction);
            var shapes1 = _topPicture.Render(topBox);
            var shapes2 = _bottomPicture.Render(bottomBox);
            return shapes1.Concat(shapes2).ToList();
        }
    }
}