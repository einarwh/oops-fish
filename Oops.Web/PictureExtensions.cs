using System.Collections.Generic;

namespace Oops.Web
{

    internal static class PictureExtensions
    {
        public static Picture Decorate(this Picture p, IEnumerable<string> decorations)
        {
            foreach (var op in decorations)
            {
                switch (op)
                {
                    case "turn":
                        p = new TurnedPicture(p);
                        break;
                    case "flip":
                        p = new FlippedPicture(p);
                        break;
                    case "toss":
                        p = new TossedPicture(p);
                        break;
                }
            }

            return p;
        }
    }
}