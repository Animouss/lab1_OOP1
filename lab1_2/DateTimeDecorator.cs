using System.Text;
namespace lab1_2
{


    // класс декоратора
    public abstract class DateTimeDecorator : ITimeFormat
    {
        protected ITimeFormat formatter;

        public DateTimeDecorator(ITimeFormat formatter)
        {
            this.formatter = formatter;
        }

        public abstract string FormatDateTime();
    }
}