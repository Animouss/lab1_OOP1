using lab1_2;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        ITimeFormat ITimeFormat;
        ITimeFormat = new EuTime();
        //ITimeFormat = new UsTime();
        ITimeFormat = new SymbolDecorator(ITimeFormat,"And");
        ITimeFormat = new SymbolDecorator(ITimeFormat,"Kaz");
        Console.WriteLine(ITimeFormat.FormatDateTime());


    }
}
