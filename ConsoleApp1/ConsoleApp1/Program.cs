using System;
using System.Net;
using System.Runtime.CompilerServices;

public class Cokkiecookbook
{
    private readonly Irepository_recepie _repositoryrecipe;
    private readonly Iuserinteraction _userinteraction;

    public Cokkiecookbook(Irepository_recepie repository_recepie, Iuserinteraction userinteraction)
    {
       _repositoryrecipe = repository_recepie;
        _userinteraction = userinteraction;
    }
    public void run(string path)
    {
        var allRecepies = _repositoryrecipe.GetAllRecepies(path);

        _userinteraction.printexistingrecepies(allRecepies);

        //var ingredients = _userinteraction.readuserinput();

        //if(ingredients.Count > 0)
        //{
        //    var recipes = new Recipe(ingredients);
        //    allRecepies.Add(recipes);
        //    _repositoryrecipe.Write(path, allRecepies);

        //    _userinteraction.Showmessage("Recipe has been added");
        //    _userinteraction.Showmessage(recipe.ToString());
        //}

        //else
        //{
        //    _userinteraction.Showmessage("No ingredients are selected , please select a ingredient again");
        //}

        _userinteraction.Exit();
        
    }
}

public class program1
{
    public static void Main(string[] args)
    {
        var cookiecookbook = new Cokkiecookbook(new repository_recepie() , new  userinteraction());
        cookiecookbook.run("recipes.txt"); 
        
    }

}



