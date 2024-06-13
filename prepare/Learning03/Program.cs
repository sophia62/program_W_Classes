using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction (3,4);
        Fraction fraction4 = new Fraction (1,3);

        Console.WriteLine(fraction1.FractionString());
        Console.WriteLine(fraction1.Decimal());

        Console.WriteLine(fraction2.FractionString());
        Console.WriteLine(fraction2.Decimal());

        Console.WriteLine(fraction3.FractionString());
        Console.WriteLine(fraction3.Decimal());

        Console.WriteLine(fraction4.FractionString());
        Console.WriteLine(fraction4.Decimal());
        




    }
}