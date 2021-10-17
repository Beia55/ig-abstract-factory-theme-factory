using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExample
{
    public abstract class Theme
    {
        public ThemeTypes Type { get; }
        public DateTime CreationDate { get; set; }
        public string Specifics { get; set; }


        protected Theme(ThemeTypes type)
        {
            Type = type;
            CreateTheme();
            AddSpecifics();
        }

        private void CreateTheme()
        {
            CreationDate = DateTime.Now.AddYears(3);
        }

        protected abstract void AddSpecifics();

        public override string ToString()
        {
            return $"The {GetType()}  was created in {CreationDate.ToShortDateString()}! \r Specifics included: {Specifics}. ";
        }

    }
}
