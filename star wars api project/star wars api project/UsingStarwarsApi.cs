using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace star_wars_api_project
{
    public class UsingStarwarsApi : MockStarWarsApiDataReader
    {
        public async void fetchdata()
        {
            var planetapidata = JsonSerializer.Deserialize<PlanetApiData>(Result);

            Console.WriteLine(planetapidata);
            Console.WriteLine($"{"Name",-10}|{"Diameter",-10}|{"SurfaceWater",-10}|{"Population",-10}|");
            Console.WriteLine("-----------------------------------------------------------");

            foreach (var data in planetapidata.results)
            {
                Console.WriteLine($"{data.name,-10}|{data.diameter,-10}|{data.surface_water,-10}|{data.population,-10}");
            }

        }
    }

}

