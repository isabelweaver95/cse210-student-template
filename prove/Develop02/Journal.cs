using System;
using Microsoft.VisualBasic;

public class Journal{
    // List<Prompt> _prompts = new List<Prompt>(); //list of prompts
    public List<Entry> _entries = new List<Entry>(); //list of entries

    public void Display(){
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }

    //this adds to a new file that the user will write too. 
    public void savingToNewFile(string filePath ){
        // Create a new text file and open it for writing
        // Your code for creating the file goes here
        using StreamWriter writer = new StreamWriter(filePath);
        foreach (Entry entry in _entries){
            writer.Write(entry._date.ToString("MM/dd/yyyy "));
            writer.WriteLine(entry.prompt);
            writer.WriteLine(entry._response);
        }
    }

//This function saves to an existing file, it should add to the text file
    public void savingToExistingFile(string filePath){
        using StreamWriter writer = new StreamWriter(filePath, true);
        foreach (Entry entry in _entries){
            writer.Write(entry._date.ToString("MM/dd/yyyy "));
            writer.Write(entry.prompt);
            writer.WriteLine(entry._response);
        }
    }

    public void Load(string filePath){
        using StreamReader reader = new StreamReader(filePath);
        string line;
        while((line = reader.ReadLine()) != null){
            Entry entry = new Entry();
            entry.prompt = line;
            entry._response = reader.ReadLine();
            _entries.Add(entry);
            entry.Display();
        }
    }
}