using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Words
{
    public string Text{get; set;}
    public bool IsHidden{get; set;}

    public Words(string text)
{

Text = text;

IsHidden = false;
}

public void Hide()

    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}
