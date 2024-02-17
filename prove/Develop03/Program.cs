using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Adam fell that men might be; and men are, that they might have joy.", "2 Nephi 2:25-55");
        bool quit = false;
        string input = "";
        while(quit == false){
            scripture.GetRenderedText();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, type restrart to restart, or type quit to exit.");
            input = Console.ReadLine();

            if(input == "quit" || input == "Quit"){
                quit = true;
            }else if(input == "restart"|| input == "Restart"){
                scripture.ClearWords();
            }else{
                scripture.HideWord();
            }

            //scripture.HideWord();
            if(scripture.AllHidden() == true){
                scripture.GetRenderedText();
                quit = true;
            }
        }
    }
}