using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample.HighlightedTheme
{
    class HighlightedThemeFactory : IThemeFactory
    {
        public IButton CreateButtons(float BorderRValue, string style)
        {
            return new HighlightedButton(BorderRValue, style);
        }

        public IWindow CreateWindows(float BorderRValue, string style, float opacityValue)
        {
            return new HighlightedWindow(BorderRValue, style, opacityValue);
        }
    }
}
