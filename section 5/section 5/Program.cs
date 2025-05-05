using System;
using System.Linq.Expressions;

public class person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public person(string name , int id)


    {
        if (name.Length <= 1)
        {
             var exception= new ArgumentException("name is null");

            Console.WriteLine(exception);
        }
        
        if (id < 0)
        {
            var exception= new ArgumentNullException("id is less than zero");

            Console.WriteLine(exception);
        }

        Name = name;
        Id = id;
    }
} 

public class ExtensionExceptions : Exception
{
    
}
public class program_1
{
     //int Getelement(IEnumerable<int> list)
     //{
        
     //       foreach(var x in list)
     //       {
     //           return x;
     //       }
        

     //   throw new Exception("The collection can not be empty hheeheh");
     //}

    

    public static void Main(string[] args)
    {
        //try
        //{
        //    string input = "hello";
        //    var number = int.Parse(input);

        //}

        //catch (Exception ex)
        //{

        //    Console.WriteLine(ex.Message);
        //}

        //finally {

        //    Console.WriteLine("program has been executed");

        //}
        //IEnumerable<int> list = new List<int>();
        //var elemrnt = new program_1();
        //elemrnt.Getelement(list);

        var person = new person("", -1);

        
    }
}