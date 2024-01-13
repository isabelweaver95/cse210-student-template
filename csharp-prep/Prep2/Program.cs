using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        char letter;
        string grade;

        Console.WriteLine("What is your grade percentage?");
        grade = Console.ReadLine();

        int gradePer = Convert.ToInt32(grade);

        if(gradePer >= 90){
            letter = 'A';
        }else if(gradePer < 90 && gradePer >= 80){
            letter = 'B';
        }else if(gradePer < 80 && gradePer >= 70){
            letter = 'C';
        }else if(gradePer < 70 && gradePer >= 60){
            letter = 'D';
        }else{
            letter = 'F';
        }

        Console.WriteLine("Your grade is an " + letter);
        if(gradePer >= 70){
            Console.WriteLine("Great Work!");
        }else {
            Console.WriteLine("Better luck next time");
        }
    }
}