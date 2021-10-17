using System;

namespace PersonalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IThemeFactory myThemeFactory = new ClassicTheme.ClassicThemeFactory();
            Console.WriteLine(myThemeFactory.CreateButtons(0.5f, "Bold").ToString());
            Console.WriteLine(myThemeFactory.CreateWindows(0.5f, "Bold", 0.5f).ToString());

            myThemeFactory = new HighlightedTheme.HighlightedThemeFactory();
            Console.WriteLine(myThemeFactory.CreateButtons(0.5f, "Italic"));
            Console.WriteLine(myThemeFactory.CreateWindows(0.5f, "Italic", 0.5f).ToString());

            myThemeFactory = new RoundedTheme.RoundedThemeFactory();
            Console.WriteLine(myThemeFactory.CreateButtons(0.5f, "Underlined").ToString());
            Console.WriteLine(myThemeFactory.CreateWindows(0.5f, "Underlined", 0.5f).ToString());

        }
    }
}
