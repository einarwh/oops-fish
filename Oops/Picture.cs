using System.Collections.Generic;
using Oops.Shapes;

namespace Oops
{
    internal abstract class Picture
    {
        public abstract IReadOnlyList<IShape> Render(Box box);
    }
}