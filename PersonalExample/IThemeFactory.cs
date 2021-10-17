using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample
{
    public interface IThemeFactory
    {
        IButton CreateButtons(float BorderRValue, string style);

        IWindow CreateWindows(float BorderRValue, string style, float opacityValue);
    }
}
