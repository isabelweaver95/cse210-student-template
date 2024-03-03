public class ListeningActivity : Activity
{
    public ListeningActivity() : base("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 4)
    {
    }

    private List<string> _questions = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public string GetRandomQuestion(){
        String question;
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        question = _questions[randomIndex];
        return question;
    }

    public void DisplayQuestion(){
        Console.WriteLine("List as many as you can of the following:");
        Console.WriteLine("--- " + GetRandomQuestion() + " ---");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
    }

}