using System;
using System.Text;
using laba_1;

var r1 = new RatNum(3, 4);
var r2 = new RatNum(7, 3);

Console.WriteLine(r1.ToString()); 
Console.WriteLine(r2.ToString()); 

Console.WriteLine(r1 + r2); 
Console.WriteLine(r1 - r2);

Console.WriteLine(-r1);

Console.WriteLine(r1 == r2); //  False
Console.WriteLine(r1 != r2); // True
Console.WriteLine(r1 < r2); //  True
Console.WriteLine(r1 > r2); //  False

