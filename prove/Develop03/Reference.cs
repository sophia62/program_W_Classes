public class Reference
{

    //Do I need a start and end verse? come back to this
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; }
        // code words without constructor? no it doesnt 
    // public Reference(string book, int chapter, int verse)
    // {
    //     Book = book;
    //     Chapter = chapter;
    //     StartVerse = verse;
    //     EndVerse = verse;
    // }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return 
             $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
            
    }
}