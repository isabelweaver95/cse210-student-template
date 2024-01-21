using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName(){
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favNumber = Convert.ToInt32(number);
        return favNumber;
    }

    static int SquareNumber(int number){
        return number * number;
    }

    static void DisplayResult(String name, int squaredNumber){
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}