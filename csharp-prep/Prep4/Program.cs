using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int numberEntered = -1;

        while (numberEntered != 0) 
{
       Console.Write("Enter some numbers, then put 0 when you want to stop.");

         string input= Console.ReadLine();
         numberEntered = int.Parse(input);
        if (numberEntered != 0)
    {
        numbers.Add(numberEntered);
    }

}
//Sum the numbers
 {
int sum = 0;

for (int i = 0; i <numbers.Count; i++)
{
    sum += numbers[i];
}
Console.WriteLine ("Sum:"+ sum);

//average of numbers in list used from example code after trying  same with max 
float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
}