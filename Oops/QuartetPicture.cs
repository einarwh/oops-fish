namespace Oops
{
    internal class QuartetPicture : Picture
    {
        private readonly Picture _picture;

        public QuartetPicture(Picture nw, Picture ne, Picture sw, Picture se)
        {
            _picture = new AbovePicture(
                new BesidePicture(nw, ne), 
                new BesidePicture(sw, se));
        }

        public override void Render(Box box)
        {
            _picture.Render(box);
        }
    }
}