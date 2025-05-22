using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("fractions program");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(3, 4);
        console.WriteLine("fractions program");
        console.WriteLine(f1.GetFractionSrtring());
        console.WriteLine(f1.GetDecimalValue());
        console.WriteLine(f2.GetFractionString());
        console.WriteLine(f2.GetDecimalValue());
    }
}