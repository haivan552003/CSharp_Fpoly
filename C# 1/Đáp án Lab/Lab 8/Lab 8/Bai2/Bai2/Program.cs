using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //Bai 2 lab8
        Hashtable weekday = new Hashtable();
        weekday.Add(1, "Sunday");
        weekday.Add(2, "Monday");
        weekday.Add(3, "Tuesday");
        weekday.Add(4, "Wednesday");
        weekday.Add(5, "Thursday");
        weekday.Add(6, "Friday");
        weekday.Add(7, "Saturday");

        foreach (DictionaryEntry item in weekday)
        {
            Console.WriteLine("{0}-{1}", item.Key, item.Value);

        }
        Console.WriteLine(weekday.Contains("Tuesday"));
    }
}