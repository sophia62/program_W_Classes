public class Breathing : Mindfullness
{
    public Breathing() : base("Breathing Activity", "This activity will walk you through a breathing activity, where you breathe in for five seconds, hold your breath for five seconds at the top, exhale for seven seconds, and hold at the bottom for five seconds. It is a common yoga practice.", 0)
    {
    }

    override public void DoActivity()
  {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Durration);
        while (DateTime.Now < endTime)

        {
            Console.WriteLine("Breathe in...");
            BreathingAnimation(5);
            Console.WriteLine("Hold...");
            BreathingAnimation(5);
            Console.WriteLine("Breathe out...");
            BreathingAnimation(7);
            Console.WriteLine("Hold...");
            BreathingAnimation(5);
        }
    }
}











// // Attributes:
// // Inherits from MindfulnessActivity
// // Methods:
// // protected override void PerformActivity()
// using System.Threading.Tasks.Dataflow;

// public class Breathing : Mindfullness
// {
//     public Breathing() : base ("Breathing Activity", "This activity will help you relax by guiding you through 
//     {

//     }
//     {

//     Name = "Breathing Activity";
//     Description = "Here is the breathing activty discription";
//     Console.WriteLine($"What is the {Durration}");

// }
// // override because the mindfullness class is abstract allowing us to use the DoActivity
//     override public void DoActivity()
//     {
//         int halfDuration = Durration / 2;
//         for (int i = 0; i < halfDuration; i++)
//     {
//         Console.WriteLine("Breath in...");
//         Thread.Sleep(5000);
//         Console.WriteLine("Breath Out...");
//     }

//     }
// }