using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> customers = new Dictionary<int, string>();

        customers.Add(1005, "Dawa");
        customers.Add(1004, "Abinash");
        customers.Add(1003, "Pasang");

        foreach (KeyValuePair<int, string> customer in customers)
        {
            Console.WriteLine("Customer ID: " + customer.Key + ", Name: " + customer.Value);
        }

        Console.ReadLine();
    }
}
