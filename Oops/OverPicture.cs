namespace Oops
{
    internal class OverPicture : Picture
    {
        private readonly Picture _p1;
        private readonly Picture _p2;

        public OverPicture(Picture p1, Picture p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public override void Render(Box box)
        {
            _p1.Render(box);
            _p2.Render(box);
        }
    }
}