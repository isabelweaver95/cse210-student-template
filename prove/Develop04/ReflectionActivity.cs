using System.Security.Cryptography.X509Certificates;

public class ReflectionActivity : Activity{

    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0){
        
    }
    
    public string GetRandomPrompt(){
        String prompt;
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        prompt = _prompts[randomIndex];
        return prompt;
    }

    public string GetRandomQuestion(){
        String question;
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        question = _questions[randomIndex];
        return question;
    }

    public void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
    }

    public void DisplayQuestion(int input){
        DateTime startTime = DateTime.Now;
        DateTime spinnerTime = startTime.AddSeconds(input / 2);

        Console.Write("> " + GetRandomQuestion() + " ");
        while(DateTime.Now < spinnerTime){
            DisplaySpinner();
        }

        Console.WriteLine(" ");
        Console.Write("> " + GetRandomQuestion() + " ");
        
        startTime = DateTime.Now;
        spinnerTime = startTime.AddSeconds(3);
        while(DateTime.Now < spinnerTime){
            DisplaySpinner();
        }
    }

}