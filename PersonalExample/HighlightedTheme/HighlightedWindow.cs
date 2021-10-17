using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample.HighlightedTheme
{
    class HighlightedWindow : Theme, IWindow
    {
        public HighlightedWindow(float BorderRValue, string style, float opacityValue) : base(ThemeTypes.Highlighted)
        {
            setBorderRadius(BorderRValue);
            setTextStyle(style);
            setOpacity(opacityValue);
        }

        public void setBorderRadius(float value)
        {
            Specifics = $"Border Radius Value = {value}";
            Console.WriteLine(Specifics);
        }

        public void setTextStyle(string style)
        {
            Specifics = $"Text Style = {style}";
            Console.WriteLine(Specifics);
        }

        public void setOpacity(float value)
        {
            Specifics = $"Opacity Value = {value}";
            Console.WriteLine(Specifics);
        }

        protected override void AddSpecifics()
        {
            Console.WriteLine(Specifics);
        }
    }
}
