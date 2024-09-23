using System;
using System.Collections.Generic;

namespace MyFirstLists
{
class Lists
{
    public static void List1(string[] args)
    {
        List<String> fruit = new List<string> {"Apple", "Banana", "Orange"};

        //Console.WriteLine(fruit.Count);
        fruit.Add("Grapes");
        fruit.Remove("Banana");
        Console.WriteLine(fruit.IndexOf("Apple"));
       

        foreach(string fruits in fruit)
        {
            Console.WriteLine(fruits);
        }
    }


}
}