using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample.RoundedTheme
{
    class RoundedButton : Theme, IButton
    {
        public RoundedButton(float BorderRValue, string style) : base(ThemeTypes.Rounded)
        {
            setBorderRadius(BorderRValue);
            setTextStyle(style);
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

        protected override void AddSpecifics()
        {
            Console.WriteLine(Specifics);
        }
    }
}
