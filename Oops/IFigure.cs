using System.Collections.Generic;

namespace Oops
{
    public interface IFigure
    {
        IReadOnlyList<IShape> Shapes { get; }
    }
}