using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f1.getFractionString());
        Console.WriteLine(f1.getDecimalValue());
        Console.WriteLine(f2.getFractionString());
        Console.WriteLine(f2.getDecimalValue());
        Console.WriteLine(f3.getFractionString());
        Console.WriteLine(f3.getDecimalValue());
    }
}