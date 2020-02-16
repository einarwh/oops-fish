namespace Oops
{
    public static class PictureExtensions
    {
        public static Picture Turn(this Picture p)
        {
            return new TurnedPicture(p);
        }

        public static Picture Flip(this Picture p)
        {
            return new FlippedPicture(p);
        }

        public static Picture Toss(this Picture p)
        {
            return new TossedPicture(p);
        }

        public static Picture Above(this Picture p, Picture q)
        {
            return new AbovePicture(p, q);
        }

        public static Picture Above(this Picture p, Picture q, double topWeight, double bottomWeight)
        {
            return new AbovePicture(p, q, topWeight, bottomWeight);
        }

        public static Picture Beside(this Picture p, Picture q)
        {
            return new BesidePicture(p, q);
        }

        public static Picture Beside(this Picture p, Picture q, double leftWeight, double rightWeight)
        {
            return new BesidePicture(p, q, leftWeight, rightWeight);
        }

        public static Picture Over(this Picture p, Picture q)
        {
            return new OverPicture(p, q);
        }
    }
}