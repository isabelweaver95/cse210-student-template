using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment._studentName = "Sammuel Bennett";
        assignment._topic = "Mathmatics";
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment._studentName = "Roberto Rodriguez";
        mathAssignment._topic = "Fractions";
        mathAssignment.setTextBookSection("Section 7.3");
        mathAssignment.setProblems(" Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment._studentName = "Mary Waters";
        writingAssignment._topic = "European History";
        writingAssignment.SetTitle("The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}