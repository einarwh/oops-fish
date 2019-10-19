namespace Oops
{
    internal class FlippedPicture : Picture
    {
        private readonly Picture _picture;

        public FlippedPicture(Picture picture)
        {
            _picture = picture;
        }

        public override void Render(Box box)
        {
            _picture.Render(box.Flip());
        }
    }
}