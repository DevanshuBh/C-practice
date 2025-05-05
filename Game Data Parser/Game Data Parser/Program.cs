using System;
using Game_Data_Parser;

public class Program_1
{
    public static void Main(string[] args)
    {
        var userinterface = new Userinterface(new userinteraction() , new jsondata());
        userinterface.run();
    }
}
