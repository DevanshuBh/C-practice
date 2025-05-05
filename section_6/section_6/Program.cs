using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//internal class ListofInts
//{
//    public int[] _items = new int[4] {1,2,3,4};
//    public int _size = 4;

//    public void addelement(int item)
//    {
//        if (_size >= _items.Length)
//        {
//            int[] new_item = new int[_size * 2];

//            for (int i = 0; i < _size; i++)
//            {
//                new_item[i] = _items[i];
//            }
//            _items = new_item;
//        }
//        else
//        {
//            _items[_size] = item;
//            _size++;
//        }
//    }

//    public void RemoveAt(int index)
//    {
//        if (index < 0 || index >= _size)
//        {
//            throw new IndexOutOfRangeException("The index is out of range");
//        }
//        else if(index == (_size-1))
//        {
//            _items[index] = 0;
//        }
//        else
//        {
//            for (int i = index; i < _size - 1; ++i)

//            _items[_size] = 0;

//        }

//    }
//}

//public class SortedList<T> where T : IComparable<T>
//{
//    public IEnumerable<T> items;

//    public SortedList(IEnumerable<T> items)
//    {
//        var listnew = items.ToList();
//        listnew.Sort();
//        this.items = listnew;
//    }
//}
//public class FullName : IComparable<FullName>
//{
//    public string FirstName { get; init; }
//    public string LastName { get; init; }

//    public override string ToString() => $"{FirstName} {LastName}";

//    public int CompareTo(FullName Other)
//    {
//        var lastname = LastName.CompareTo(Other.LastName);
//        if(lastname != 0)
//        {
//        }

//        return FirstName.CompareTo(Other.FirstName);
//    }

//}

public class NumbersFilter
{
    public List<int> FilterBy(string filteringType, List<int> numbers)
    {
        switch (filteringType)
        {
            case "Even":

                SelectEven(numbers);

            case "Odd":
                result = Selectodd(numbers);
                break;

            default:
                throw new NotSupportedException("The input is not valid");
        }
    }
}

public class program
{
    //delegate void printmessage(string message);

    //public void print(string message)
    //{
    //    Console.WriteLine(message);
    //}

    public List<int> SelectEven(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var item in numbers)
        {
            if (item % 2 == 0)
            {
                result.Add(item);
            }
        }

        return result;
    }

    public List<int> Selectodd(List<int> numbers)
    {
        var result = new List<int>();
        foreach (var item in numbers)
        {
            if (item % 2 == 1)
            {
                result.Add(item);
            }
        }

        return result;



    }

    public static void Main(string[] args)
    {

        //var add = new ListofInts();

        //add.addelement(20);
        //add.addelement(30);
        //add.addelement(40);
        //add.addelement(50);
        //add.addelement(60);

        //foreach(int i in add._items)
        //{
        //    Console.WriteLine(i);
        //}
        //add.RemoveAt(2);

        //foreach(int i in add._items)
        //{
        //    Console.WriteLine(i);
        //}

        //IEnumerable<T> Createhello<T>(int maxLength)
        //{
        //    var length = new Random().Next(maxLength + 1);
        //    var result = new List<T>();

        //    for (int i  = 0; i<length; ++i)
        //    {
        //        result.Add(new T());
        //    }

        //    return result;

        //}

        //var hello = new program();
        //printmessage message = hello.print;

        //message("hello");

        var numbers = new List<int> { 1, 2, 4, -10, 80, -4, -6, -30 };
        Console.WriteLine(@"Even or odd");


        var input = Console.ReadLine();

        List<int> result;

        
    }




            




}