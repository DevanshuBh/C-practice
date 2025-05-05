
using System.Runtime.CompilerServices;
using star_wars_api_project;

public class User
{
    
    public int choice()
    {
        
        bool loop = true;
        int user_choice;
        do
        {
            Console.WriteLine("\nThe statistics of which property would you like to see?\n");
            Console.WriteLine("1.population");
            Console.WriteLine("2.diameter");
            Console.WriteLine("3.surface water");

            string choice = Console.ReadLine();
            bool validInput = int.TryParse(choice, out  user_choice);

            if (!validInput)
            {
                Console.WriteLine("Please select a valid Input");
            }

            else
            {
                loop = false;

            }
        }
        while (loop);

        return user_choice;


    }

    

    public void exit()
    {
        
    }
}