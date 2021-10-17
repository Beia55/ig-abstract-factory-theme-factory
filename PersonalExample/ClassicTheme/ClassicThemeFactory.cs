using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample.ClassicTheme
{
    class ClassicThemeFactory : IThemeFactory
    {
        public IButton CreateButtons(float BorderRValue, string style)
        {
            return new ClassicButton(BorderRValue, style);
        }

        public IWindow CreateWindows(float BorderRValue, string style, float opacityValue)
        {
            return new ClassicWindow(BorderRValue, style, opacityValue);
        }
    }
}
