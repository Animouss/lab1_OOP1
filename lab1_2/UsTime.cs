using System;
using System.Globalization;
using System.Text;
namespace lab1_2
{
    // европейский стиль
    public class UsTime : ITimeFormat
    {
        public string FormatDateTime()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("us-US");
            return DateTime.Now.ToString(culture);
        }
    }
}