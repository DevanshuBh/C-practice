
using ConsoleApp1.Recipes;

public interface Iuserinteraction
{
    void ShowMessage(string message);
    void Exit();
    void printexistingrecepies(IEnumerable<Recipe> allRecepies);
}
public class userinteraction : Iuserinteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Enter any key to exit");
        Console.ReadKey();
    }

    public void printexistingrecepies(IEnumerable<Recipe> allRecipes)
    {
        if(allRecipes.Count() > 0)
        {
            int count = 0;
            foreach(var recipe in allRecipes)
            {
                Console.WriteLine($"*****{count + 1}*****");
                Console.WriteLine(recipe);
                count++;
            }
        }
    }
}