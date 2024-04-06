using System.Dynamic;

public class Inventory{
    public List<Food> _inventory {get; set;}

    public Inventory(){
        _inventory = new List<Food>();
    }

    virtual public void AddFood(Food food){
        Console.WriteLine("Food name, Quantity, Units");
        _inventory.Add(food);
    }

    virtual public void DisplayInventory(){
        foreach(Food food in _inventory){
            food.Display();
        }
    }

    virtual public void RemoveFood(Food food){
        _inventory.Remove(food);
    }

    public bool IsFoodGone(Food food){
        if(_inventory.Contains(food)){
            foreach (Food f in _inventory){
                if(f._name == food._name){
                    if(f._quantity == 0){
                        _inventory.Remove(f);
                        return true;
                    }else
                        return false;
                }else
                    return false;
            }   
        }
        return true;
    }

    public void UseFood(string food, int amount){
        foreach(Food f in _inventory){
            if(f._name == food){
                f._quantity -= amount;
            }
        }

    }
}