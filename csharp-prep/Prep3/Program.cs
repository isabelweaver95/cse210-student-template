using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Boolean isValue = true;
        Console.Write("What is the magic Number? ");
        string magic = Console.ReadLine();
        int magicNumber = Convert.ToInt32(magic);

        while(isValue){
            Console.Write("What is your guess? ");
            string guessed = Console.ReadLine();
            int guess = Convert.ToInt32(guessed);
            if(guess < magicNumber){
                Console.WriteLine("Higher");
            }else if (guess > magicNumber){
                Console.WriteLine("Lower");
            }else{
                Console.WriteLine("You Guessed it!");
                isValue = false;
            }

        }
    }
}