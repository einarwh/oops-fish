using System.Collections.Generic;

namespace Oops
{
    internal abstract class Picture
    {
        public abstract IReadOnlyList<IShape> Render(Box box);

        public Picture Turn()
        {
            return new TurnedPicture(this);
        }

        public Picture Flip()
        {
            return new FlippedPicture(this);
        }

        public Picture Toss()
        {
            return new TossedPicture(this);
        }

        public Picture Above(Picture p)
        {
            return new AbovePicture(this, p);
        }

        public Picture Above(Picture p, double topWeight, double bottomWeight)
        {
            return new AbovePicture(this, p, topWeight, bottomWeight);
        }

        public Picture Beside(Picture p)
        {
            return new BesidePicture(this, p);
        }

        public Picture Beside(Picture p, double leftWeight, double rightWeight)
        {
            return new BesidePicture(this, p, leftWeight, rightWeight);
        }

        public Picture Over(Picture p)
        {
            return new OverPicture(this, p);
        }
    }
}