public class Food
{
    public string _name {get; set;}
    public int _quantity {get; set;}
    public Food(string name,  int quantity)
    {
        _name = name;
        _quantity = quantity;
    }

    public Food(){
        _name = "";
        _quantity = 0;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} ({_quantity})");
    }
}