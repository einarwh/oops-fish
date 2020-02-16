using System.Collections.Generic;
using System.Linq;

namespace Oops.Svg
{
    public class DSvgAttribute : SvgAttribute
    {
        public DSvgAttribute(IReadOnlyList<SvgPathCommand> commands)
            : base("d", ToDString(commands)) { }

        private static string ToDString(IReadOnlyList<SvgPathCommand> commands)
        {
            return string.Join(" ", 
                commands.Select(it => it.ToString()));
        }
    }
}