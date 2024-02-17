using System.Reflection.PortableExecutable;

public class Referance
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Referance(string verses){
        string[] words = verses.Split(' ', ':', '-');

        if(words[0]== "1" || words[0] == "2" || words[0] == "3" || words[0] == "4"){
            _book = words[0] + " " + words[1];
            words = words.Skip(1).ToArray();
            //Console.WriteLine(words[0]);
            words = words.Skip(1).ToArray();
            //Console.WriteLine(words[0]);
        } else {
            _book = words[0];
            words = words.Skip(0).ToArray();
            Console.WriteLine(words[0]);
        }

        for(int i = 0; i < words.Length; i++){
            if(i == 0){
                _chapter = int.Parse(words[i]);
            }else if(i == 1){
                _verse = int.Parse(words[i]);
            }else{
                _endVerse = int.Parse(words[i]);
            }
        }

        if(words.Length != 3){
            _endVerse = -1;
        }
    }

    public string GetReferance(){
        string referance; 

        if(_endVerse == -1){
            referance = _book + " " + _chapter + ":" + _verse;
        }else{
            referance = _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }

        return referance;
    }
}