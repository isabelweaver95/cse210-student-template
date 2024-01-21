using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Boolean exiting = true;
        int number;
        int sum = 0;
        float average;
        int highest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(exiting){
            Console.Write("Enter number: ");
            string strNum = Console.ReadLine();
            number = Convert.ToInt32(strNum);
            if(number == 0){
                exiting = false;
            }else{
                //why dont add the number to sum here? saves time
                // we can also compare if the number is the highest here too.
                // if we do this we dont have to loop through the list to find them.
                numbers.Add(number);
                sum += number;

                if(number > highest){
                    highest = number;
                }
            }
        }

        //lets find the average now
        int length = numbers.Count;
        average = sum/length;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highest}");
        
    }
}