using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Assignment class
        Assignment assignment = new Assignment("SName BName", "Multiplication");
        Console.WriteLine(assignment.GetSummary()); 

        // Test MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("hey hey", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary()); 
        Console.WriteLine(mathAssignment.GetHomeworkList()); 

        // Test WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Dude Dude ", "History", "IDK IDK ");
        Console.WriteLine(writingAssignment.GetSummary()); 
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
