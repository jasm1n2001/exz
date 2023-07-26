
using task3;

var cl1 = new Calculator(5,6);
char n = Convert.ToChar(Console.ReadLine());



    if(n == '+') {System.Console.WriteLine(cl1.Sum());}
    if(n == '-') System.Console.WriteLine(cl1.Subtract());
    if(n == '*') System.Console.WriteLine(cl1.Multiplication());
    if(n == '/') System.Console.WriteLine(cl1.Division());
