using System;
using System.Collections.Generic;
using System.Linq;

namespace Oops.Svg
{
    public class SvgDocument
    {
        private readonly int _height;
        private readonly int _width;
        private readonly IReadOnlyList<SvgElement> _elements;

        public SvgDocument(int height, 
            int width, 
            IReadOnlyList<SvgElement> elements)
        {
            _height = height;
            _width = width;
            _elements = elements;
        }

        public override string ToString()
        {
            var els = 
                string.Join(Environment.NewLine, 
                    _elements.Select(it => it.ToString()));

            var result = $"<svg xmlns=\"http://www.w3.org/2000/svg\" xmlns:svg=\"http://www.w3.org/2000/svg\" version=\"1.2\" height=\"{_height}\" width=\"{_width}\">{Environment.NewLine}{els}{Environment.NewLine}</svg>";

            return result;
        }
    }
}