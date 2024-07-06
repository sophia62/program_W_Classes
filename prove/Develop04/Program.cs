using System;
public class Program

{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            Mindfullness activity;
            switch (choice)
            {
                case "1":
                    activity = new Breathing();
                    break;
                case "2":
                    activity = new Reflection();
                    break;
                case "3":
                    activity = new Listing();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.StartActivity();
            Console.Clear();
        }
    }
}

// Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.
// Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.
// Listing Activity - Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.