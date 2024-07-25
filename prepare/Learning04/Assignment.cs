// Assignment class definition
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for student name (for use in derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }
}
