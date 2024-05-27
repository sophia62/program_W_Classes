//All of the below is wrong code that I tried but below is the correct code. 

// using System;
// using System.Globalization;
// {
// Console.WriteLine("Hello Prep3 World!");
// Console.WriteLine("What is the Magic Number?");
// Random random = new Random();
// int number = random.Next(1, 100);
// int min = 0;
// int max = 100;
// int guess = 0;
// int realnumber;


// {
//         realnumber = random.Next(min, max);

//     Console.WriteLine("Guess any number between 0 and 100");

//     while (guess != realnumber )
//     guess = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Guess: " + guess);

//     if (guess > realnumber)
//     {
//         Console.WriteLine("Guess is too low");
//     }
//     else if (guess < realnumber)
//     {
//     Console.WriteLine("guess is too high");
//     }
//     else 
//     {
//     Console.WriteLine("Thats Correct!");
//     }

//     Console.WriteLine ("Number" + realnumber);
//     Console.WriteLine("You Win");




// }
// }

using System;

class GuessingGame
{
    static void Main()
    {

        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        
        int guess = 0;

        // Loop
        for (; guess != magicNumber;)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
