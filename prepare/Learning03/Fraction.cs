public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public void setTop(int top){
        _top = top;
    }

    public void setBottom(int bottom){
        _bottom = bottom;
    }

    public int getTop(){
        return _top;
    }

    public int getBottom(){
        return _bottom;
    }

    public string getFractionString(){
        return _top + "/" + _bottom;
    }

    public double getDecimalValue(){
        double top = _top;
        double bottom = _bottom;
        return top/bottom;
    }

}