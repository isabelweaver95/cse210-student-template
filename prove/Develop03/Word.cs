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

    public string GetRenderedWord(){
        char[] charArray = _word.ToCharArray();
        if(_hidden){
            foreach(int i in charArray){
                charArray[i] = '_';
            }
            return charArray.ToString();
        }else  
            return _word;
    }
}