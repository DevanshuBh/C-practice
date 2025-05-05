using System;

namespace Game_Data_Parser
{
    public class userinteraction
    {
        public string UserInput { get; set; }

        public void user_input()
        {
            bool x = true;
            while (x)
            {
                Console.Write("Enter the name of the file you want to read: ");
                try
                {
                    string user_input = Console.ReadLine();

                    UserInput = user_input;


                    if (!File.Exists(UserInput))
                    {
                        Console.WriteLine("File Does not Exist");
                    }

                    else
                    {
                      
                        x = false;

                    }
                    
                    
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Input can not be NUll");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid value.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Unexpected error occurred! Please try again.");
                }

                
            }
        }
    }
}