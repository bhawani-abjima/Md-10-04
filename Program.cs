using System;
using System.Collections.Generic;
using System.Linq;



public record Person
{                                                                      //declaration of records
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string LastName { get; set; }
    public string FirstName { get; set; }
}
public record Emplyoee
{
    public int EmpId { get; init; }
    public string? EmpName { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        var person1 = new Person("Adam ", "Eve");
        var person2 = new Person("Chris", "Evans");
        var person3 = new Person("Chris", "Evans");

        Console.WriteLine($"Person1 == Person2? {person1 == person2}");
        Console.WriteLine($"Person1 == Person3? {person1 == person3}");
        Console.WriteLine($"Person2 == Person3? {person2 == person3}");


        Emplyoee obj = new Emplyoee
        {
            EmpId = 1001,
            EmpName = "hamesworth jane"
        };
        var emp1 = obj with { EmpName = "luke james", EmpId = 203 };
        Console.WriteLine(obj.EmpName + " " + emp1.EmpName);

        int[] numbers = { 15,101,23,99 };          //creating array 

        Console.WriteLine("Element in first: " + numbers[0]);
        Console.WriteLine("Element in second: " + numbers[1]);
        Console.WriteLine("Element in third: " + numbers[2]);
        Console.WriteLine("Element in fourth: " + numbers[3]);

        Console.WriteLine("Smallest  Element: " + numbers.Min());           //max and min element from array
        Console.WriteLine("Largest Element: " + numbers.Max());


        int[,] numbers1 = { { 256, 356 }, { 456, 556 } };                           //multi-dimensional array

        Console.WriteLine("Element at index [0, 0] : " + numbers1[0, 0]);
        numbers1[0, 0] = 222;
        Console.WriteLine("Element at index [0, 0] : " + numbers1[0, 0]);
        Console.WriteLine("Element at index [1, 0] : " + numbers1[1, 0]);



        float sum = numbers.Sum();
        int count = numbers.Count();
        float average = sum / count;
        Console.WriteLine("Average : " + average);
        Console.WriteLine("Average using Average() : " + numbers.Average());  //calculating average 


        Console.WriteLine("Array elements...");
        string[] arr = { "car", "bike", "truck", "bus" };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
        string? res = Array.Find(arr, ele => ele.StartsWith("b", StringComparison.Ordinal)); //finding in array
        Console.Write("Searched element...");
        Console.Write("{0}", res);


        int m = 0;
        int pos;
        int[] arrw = new int[5] { 3588, 5077, 5515, 7070, 9832 };

        Console.WriteLine("Elements before deletion:");
        for (m = 0; m < 5; m++)
        {
            Console.WriteLine("Element[" + (m) + "]: " + arrw[m]);
        }

        pos = 2;
        for (m  = pos - 1; m < 4; m++)
        {
            arrw[m] = arrw[m + 1];
        }
        Console.WriteLine("Elements after deletion: ");              //deletion from a array
        for (m = 0; m < 4; m++)
        {
            Console.WriteLine("Element[" + (m + 1) + "]: " + arrw[m]);
        }

                                                                     // Creating a dictionary
        Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

        
        My_dict1.Add(1123, "Black");
        My_dict1.Add(1124, "Ops");
        My_dict1.Add(1125, "Wolfs 5.0");

        foreach (KeyValuePair<int, string> El in My_dict1)
        {
            Console.WriteLine("{0} and {1}",
                      El.Key, El.Value);
        }
        Console.WriteLine();

        Dictionary<string, string> My_dict2 =
                new Dictionary<string, string>(){ {"a.1", "sgt.Soap"},{"a.2", "sgt.Ghost"},{"a.3", "sgt.Mack"} };

        foreach (KeyValuePair<string, string> M2 in My_dict2)
        {
            Console.WriteLine("{0} and {1}", M2.Key, M2.Value);
        }

        if (My_dict1.ContainsKey(1122) == true)                    //to check given value present or not
        {
            Console.WriteLine("Key is found...!!");
        }

        else
        {
            Console.WriteLine("Key is not found...!!");
        }


        if (My_dict1.ContainsValue("Bhawani") == true)
        {
            Console.WriteLine("Value is found...!!");
        }

        else
        {
            Console.WriteLine("Value is not found...!!");
        }

        string[] arr1 = { "Table", "Chair", "Pen", "Clip", "Table" };    //sets
        Console.WriteLine(string.Join(",", arr1));

       
        var h = new HashSet<string>(arr1);         
        string[] arr2 = h.ToArray();
        Console.WriteLine(string.Join(",", arr2));

       

        Console.ReadKey();
    }
}