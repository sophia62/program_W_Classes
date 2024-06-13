using System.IO;

public class Writing
{
    public void WriteToFile(string fileName, string content)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(content);
        }
    }
}
