public class CookBook
{
    public List<Recipe> _recipes {get; set;}

    public CookBook(){
        _recipes = new List<Recipe>();
    }
    public void AddRecipe(Recipe recipe){  
        _recipes.Add(recipe);
    }

    public void DisplayRecipes(){
        foreach(Recipe recipe in _recipes){
            recipe.Display();
        }
    }

    public void displayAllRecipesName(){
        int i = 1;
        foreach(Recipe recipe in _recipes){
            Console.WriteLine($"{i}. {recipe._name}");
            i++;
        }
    }

    public void DisplayCertainRecipe(string name){
        foreach(Recipe recipe in _recipes){
            if(recipe._name == name){
                recipe.Display();
                return;
            }   
        } 
        
        Console.WriteLine("Recipe not found");
    }

}