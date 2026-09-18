// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Console.WriteLine($"Numerator: {f1.GetTop()}");
        Console.WriteLine($"Denominator: {f1.GetBottom()}");
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}\n");

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Numerator: {f2.GetTop()}");
        Console.WriteLine($"Denominator: {f2.GetBottom()}");
        Console.WriteLine($"Fraction: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal: {f2.GetDecimalValue()}\n");

        f1.SetTop(3);
        f1.SetBottom(4);

        Console.WriteLine($"Numerator: {f1.GetTop()}");
        Console.WriteLine($"Denominator: {f1.GetBottom()}");
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}\n");

        Fraction f3 = new Fraction(1, 3);
        Console.WriteLine($"Numerator: {f3.GetTop()}");
        Console.WriteLine($"Denominator: {f3.GetBottom()}");
        Console.WriteLine($"Fraction: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}\n");
    }
}
// End Program.cs