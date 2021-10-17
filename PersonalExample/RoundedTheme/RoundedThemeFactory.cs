using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample.RoundedTheme
{
    class RoundedThemeFactory : IThemeFactory
    {
        public IButton CreateButtons(float BorderRValue, string style)
        {
            return new RoundedButton(BorderRValue, style);
        }

        public IWindow CreateWindows(float BorderRValue, string style, float opacityValue)
        {
            return new RoundedWindow(BorderRValue, style, opacityValue);
        }
    }
}
