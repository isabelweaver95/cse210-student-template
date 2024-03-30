public class Recipe
{
    public string _name {get; set;}
    public List<Food> _ingredients {get; set;}
    public string _instructions {get; set;}

    public Recipe(string name, List<Food> ingredients, string instructions)
    {
        _name = name;
        _ingredients = ingredients; 
        _instructions = instructions;
    }

    public Recipe(){
        _name = "";
        _ingredients = new List<Food>();
        _instructions = "";
    }

    public void Display()
    {
        Console.WriteLine($"{_name}");
        foreach(Food food in _ingredients){
            food.Display();
        }   
        Console.WriteLine($"{_instructions}");
    }

    public void EnoughIngredients(List<Food> inventory){
        foreach(Food food in _ingredients){
            if(inventory.Contains(food) == false){
                Console.WriteLine("You don't have enough ingredients to make this recipe");
                return;
            }
        }
    }

    public List<Food> MakeRecipe(List<Food> inventory){
        foreach(Food food in _ingredients){
            foreach(Food f in inventory){
                if(f._name == food._name){
                    f._quantity -= food._quantity;
                }
            }
        }

        return inventory;
    }

}