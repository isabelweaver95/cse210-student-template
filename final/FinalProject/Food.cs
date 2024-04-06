public class Food
{
    public string _name {get; set;}
    public int _quantity {get; set;}
    public string units {get; set;}
    public Food(string name,  int quantity, string unit)
    {
        _name = name;
        _quantity = quantity;
        units = unit;
    }

    public Food(){
        _name = "";
        _quantity = 0;
        units = "";
    }

    public void Display()
    {
        Console.WriteLine($"{_name}: {_quantity} {units}");
    }
}