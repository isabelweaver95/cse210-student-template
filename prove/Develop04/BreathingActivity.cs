using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    private int _breathingIn;
    private int _breathingout;

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 4)
    {
    }

    public void DisplayBreathing(int input){
        _breathingIn = 4;
        _breathingout = 6;
        
        for(int i = 0; i <= input - 1; i++){
            Console.Write("Breath in... ");
            DisplayCountdown(_breathingIn);
            Console.WriteLine(" ");
            Console.Write("Breath out... ");
            DisplayCountdown(_breathingout);
            Console.WriteLine(" ");
        }
    }

}