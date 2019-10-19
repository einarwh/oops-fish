namespace Oops
{
    internal class TurnedPicture : Picture
    {
        private readonly Picture _picture;

        public TurnedPicture(Picture picture)
        {
            _picture = picture;
        }

        public override void Render(Box box)
        {
            _picture.Render(box.Turn());
        }
    }
}