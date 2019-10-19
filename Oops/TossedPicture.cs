namespace Oops
{
    internal class TossedPicture : Picture
    {
        private readonly Picture _picture;

        public TossedPicture(Picture picture)
        {
            _picture = picture;
        }

        public override void Render(Box box)
        {
            _picture.Render(box.Turn());
        }
    }
}