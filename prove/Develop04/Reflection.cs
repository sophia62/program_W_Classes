public class Reflection : Mindfullness
{
    private static List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() :base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. I Will give you a prompt to think about for 10 seconds, then some spitfire questions about the prompt.", 0)
    {
    }

     override public void DoActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        PauseWithAnimation(10);
        
         DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Durration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            PauseWithAnimation(4);
        }
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(questions.Count);
        return questions[index];
    }
}
