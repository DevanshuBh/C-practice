using ConsoleApp1.Recipes;
using ConsoleApp1.Recipes.ingredients;

public interface Irepository_recepie
{
    List<Recipe> GetAllRecepies(string filepath);
}
public class repository_recepie : Irepository_recepie
{
    public List<Recipe> GetAllRecepies(string filepath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredients>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()
            }),

            new Recipe (new List<Ingredients>
            {
                new Cocoa_Powder(),
                new Cocoa_Powder(),
                new Cinnamon()
            })
        };
    }
}