using System.Dynamic;

public class Inventory{
    public List<Food> _inventory {get; set;}

    public Inventory(){
        _inventory = new List<Food>();
    }

    public void AddFood(Food food){
        _inventory.Add(food);
    }

    public void DisplayInventory(){
        foreach(Food food in _inventory){
            food.Display();
        }
    }

    public void RemoveFood(Food food){
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

    public void UseFood(Food food){
        if(!_inventory.Contains(food)){
            Console.WriteLine("You don't have that food in your inventory");
        }else{
            foreach(Food f in _inventory){
                if(f._name == food._name){
                    f._quantity--;
                }
            }
        }
    }
}