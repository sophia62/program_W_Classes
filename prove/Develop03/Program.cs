using System;

public class Program
{
    public static void Main(string[] args)
    // insert the reference class, then variable, to create a new object for reference and scripture. 
    {
        Reference reference = new Reference("Isaiah", 41, 10, 13);
        Scripture scripture = new Scripture(reference, "Fear thou not, for I am with thee, be not dismayed, for I am thy God: I will strengthen thee, yea, I will help thee, yea, I will uphold thee with the right hand of my righteousness.");
        // so every time I press enter, it won't repeat the scripture
        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
        // add a while loop. if quit then it will quit the program, 
        // if enter them it will continue to hide the words until it has ended. 
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "\nquit")
                break;
            //32 bit hide 3 random words
            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            }
        }
    }
}

