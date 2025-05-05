using System.Text.Json;

namespace Game_Data_Parser
{
    public class jsondata
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public float Rating { get; set; }

        public void read(string filename)
        {
            string jsonstring = File.ReadAllText(filename);

            if (jsonstring == "")
            {
                Console.WriteLine("No Games are present in the input file");
            }
            else
            {
                try
                {
                    List<jsondata> userinfo = JsonSerializer.Deserialize<List<jsondata>>(jsonstring);
                    Console.WriteLine("Loaded games are : ");
                    foreach (var user in userinfo)
                    {
                        Console.WriteLine($"{user.Title} ,released in {user.ReleaseYear}, rating: {user.Rating}\n");
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"JSON in the {filename} was not in a valid format.");
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(jsonstring);
                    Console.ResetColor();

                    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
                }
            }
        }
    }
}