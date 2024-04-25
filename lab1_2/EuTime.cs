using System;
using System.Globalization;
using System.Text;

// европейский стиль
namespace lab1_2
{
    public class EuTime : ITimeFormat
    {
        

        public string FormatDateTime()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("eu-EU");
            return DateTime.Now.ToString(culture);
        }
    }
}