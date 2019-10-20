using System.Collections.Generic;

namespace Oops
{
    internal class NonetPicture : Picture
    {
        private readonly Picture _nonet;

        public NonetPicture(Picture nw, Picture nm, Picture ne, Picture mw, Picture mm, Picture me, Picture sw, Picture sm, Picture se)
        {
            _nonet = new ColumnPicture(
                new RowPicture(nw, nm, ne),
                new RowPicture(mw, mm, me),
                new RowPicture(sw, sm, se));
        }

        public override IReadOnlyList<IShape> Render(Box box)
        {
            return _nonet.Render(box);
        }

        private class RowPicture : Picture
        {
            private readonly Picture _row;

            public RowPicture(Picture w, Picture m, Picture e)
            {
                _row = new BesidePicture(w, new BesidePicture(m, e), 1, 2);
            }

            public override IReadOnlyList<IShape> Render(Box box)
            {
                return _row.Render(box);
            }
        }

        private class ColumnPicture : Picture
        {
            private readonly Picture _column;

            public ColumnPicture(Picture n, Picture m, Picture s)
            {
                _column = new AbovePicture(n, new AbovePicture(m, s), 1, 2);
            }
            
            public override IReadOnlyList<IShape> Render(Box box)
            {
                return _column.Render(box);
            }
        }
    }
}