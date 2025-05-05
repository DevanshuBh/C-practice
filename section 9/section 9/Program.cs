using System;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


//public class Dog
//{
//    public string Name { get; set; }

//    public string species { get; set; }
//    public Dog(string name , string species)
//    {
//        Name = name;
//        this.species = species;
//    }
//}

//public class Bird
//{
//    public string Name { get; set; }
//    public string Species { get; set; }

//    public Bird(string name , string Species)
//    {
//        Name = name;
//        this.Species = Species;
//    }
//}
//public class section_9
//{
//    public static void main(string[] args)
//    {

//    }
//}

// Structs



// class equal method (how to overrride it)

/* public class hello
{
    public string Firstname;

    public string LastName;

    public hello(string firstname, string lastname)
    {
        Firstname = firstname;
        LastName = lastname;
    }

    public override bool Equals(object? obj)
    {
        return obj is hello other && other.Firstname == Firstname && other.LastName == LastName;
    }
}

public class program1
{
    public static void Main(string[] args)
    {
        hello one = new hello("dupinder", "singh");
        hello two = new hello("dupinder", "singh");

        Console.WriteLine(one.Equals(two));
    }
} */


// How to use reflections in c#

/*
public class onePerson
{
    public string Name { get; set; }

    public string Lastname { get; set; }

    public void display()
    {
        Console.WriteLine($"{Name} : {Lastname}");
    }

    public override string ToString() => "My name is devanshu bhargava";
    
}

public class program1
{
    public static void Main(string[] args)
    {
        onePerson one = new onePerson();

        Assembly assembly = Assembly.GetExecutingAssembly();

        Type[] type = assembly.GetTypes();

        foreach(var item in type)
        {

            MethodInfo[] method = item.GetMethods();

            foreach(var i in method)
                Console.WriteLine($"methods are {i}");
            {
            }

            PropertyInfo[] properties = item.GetProperties();

            foreach(var z in properties)
            {
                Console.WriteLine($"{z}");
            }
        }
    }
}

*/

public struct hello : IEquatable<hello>
{
    public string Name { get; set; }

    public string LastName { get; set; }

    public hello(string name , string lastname)
    {
        Name = name;

        LastName = lastname;
    }

    public bool Equals(hello hi)
    {
        return this.Name == hi.Name;
    }
}

public class program1
{
    public static void Main(string[] args)
    {
        hello devanshu = new hello("devanshu", "bhargava");

        hello devanshu2 = new hello("devanshu", "bhargava");


        Console.WriteLine(devanshu.Equals(devanshu2));

    }

}



