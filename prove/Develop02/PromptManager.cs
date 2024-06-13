using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class PromptManager
    {
        private List<string> prompts = new List<string>
        {
            "How was your day?",
            "One positive thing that happened today?",
            "Write a poem.",
            "Write a haiku.",
            "Write about the food you ate.",
            "Write 3 things you learned in school."
        };

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
