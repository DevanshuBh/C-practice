using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using star_wars_api_project;

public class Planets
{
    private PlanetApiData _planetSchema;
    public int Max = int.MinValue;
    public int Min = int.MaxValue;
    public int Counter = 0;
    public int indexofmaxvalue { get; set; }

    public int indexofminvalue { get; set; }

    public void userchoicedata(string user_choice)
    {
        if (user_choice == "2")
        {
            foreach (var planets in _planetSchema.results)
            {
                bool validParsing = int.TryParse(planets.population, out int planetPopulation);
                if (validParsing && planetPopulation > Max)
                {
                    Max = planetPopulation;
                    indexofmaxvalue = Counter;
                }
                else if (validParsing && planetPopulation < Min)
                {
                    Min = planetPopulation;
                    indexofminvalue = Counter;
                }

                Counter++;
            }
        }

        else if(user_choice == "2")
        {
            
        }
        
    }
}