public class Entry
{
    //here I am using encapsulation (get,set)  to get access to the properties later in the code. 
    //this is for the journal entrys
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
    }

//again, with the override of the string to make it public so i can use it in the program.cs
    public override string ToString()
    {
        return $"{Prompt}: {Response}";
    }
}
