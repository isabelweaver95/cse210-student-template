using System;

public class Entry
{
    public string _response;
    public string prompt;
    public DateTime _date = DateTime.Now;

    public void Display(){
        Console.Write(_date.ToString("MM/dd/yyyy "));
        Console.WriteLine(prompt);
        Console.WriteLine(_response);
    }

}