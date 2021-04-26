using System.IO;
using System;

class Class1
{
    void sum(int a, int b)
    {
        Console.WriteLine("Sum of a+b= "+(a+b));
    }
    void sum(double a, double b)
    {
        Console.WriteLine("Sum of a+b = "+(a+b));
    }
    static void Main()
    {
       Class1 class1 = new Class1();
       class1.sum(2,2);
       class1.sum(2.5,3.2);
       Console.ReadLine();
    }
}

