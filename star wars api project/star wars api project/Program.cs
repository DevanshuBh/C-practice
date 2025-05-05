using System;
using System.Reflection.Metadata;
using System.IO;
using star_wars_api_project;


public class StarWarsApiProject
{
    public static void Main(string[] args)
    {
        Planets planets = new Planets();
        User user = new User();
        UsingStarwarsApi usingStarWarsApi = new UsingStarwarsApi();

        usingStarWarsApi.fetchdata();
        
        user.choice();
        planets.userchoicedata();
        user.exit();

        Console.ReadKey();

        
    }
}