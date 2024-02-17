public class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden(){
        return _hidden;
    }

    public void SetHidden(){
        _hidden = true;
    }

    public void clearWord(){
        _hidden = false;
    }

    public void GetRenderedWord(){
        char[] charArray = _word.ToCharArray();

        if(_hidden){
            foreach(int i in charArray){
                //Console.Write("_");
                //Console.Write(charArray[i]);
                if(i != ',' || i != '.' || i != ';' || i != ':'){
                    Console.Write("_");
                }else{ 
                    Console.Write(charArray[i].ToString());
                }
            }
            Console.Write(" ");
        }else{
            Console.Write(_word + " ");
        }
    }
}