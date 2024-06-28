using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    //create a list from class
    public List<Words> Words { get; private set; }
        // set constructor 
    public Scripture(Reference reference, string text)
    {
        //why not this.Reference
        Reference = reference;
        Words = new List<Words>();
        //sprit the words in text 
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Words(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        //formula for random words
        
        for (int i = 0; i < count; i++)
        {
            int index;
            do
            {
                index = random.Next(Words.Count);
            } while (Words[index].IsHidden);

            Words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public override string ToString()
    {
        var words = new List<string>();
        foreach (var word in Words)
        {
            words.Add(word.ToString());
        }
        return $"{Reference}\n{string.Join(" ", words)}";
    }
}