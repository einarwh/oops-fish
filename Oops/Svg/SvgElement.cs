using System.Collections.Generic;
using System.Linq;

namespace Oops.Svg
{
    public abstract class SvgElement
    {
        private readonly string _elementName;
        private readonly IReadOnlyList<SvgAttribute> _attributes;

        protected SvgElement(string elementName, IEnumerable<SvgAttribute> attributes)
        {
            _elementName = elementName;
            _attributes = attributes.ToList();
        }

        public override string ToString()
        {
            var attrStr = string.Join(" ",
                _attributes.Select(it => it.ToString()));
            return $"<{_elementName} {attrStr} />";
        }
    }
}