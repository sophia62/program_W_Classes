using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



public class Fraction
{
    private int TopFraction;
    
    private int BottomFraction;

    public Fraction()
{
    TopFraction = 1;
    BottomFraction = 1;
}

public Fraction(int TopFractionParameter)
{
    TopFraction = TopFractionParameter;
    BottomFraction = 1;
}

public Fraction(int TopFractionParameter2, int BottomFractionParameter)
{
    TopFraction = TopFractionParameter2;
    BottomFraction = BottomFractionParameter;
}

public string FractionString()
{
    string text= $"{TopFraction}|{BottomFraction}";
    return text;
}
public double Decimal()
{
    return (double)TopFraction / (double)BottomFraction;
}
}