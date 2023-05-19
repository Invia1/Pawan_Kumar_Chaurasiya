using System;
using System.Collections.Generic;

class Firsthasset
{
    static public void Main()                 // Main Method
    {  
       
        HashSet<string> hash1 = new HashSet<string>();              // Creating HashSet, Using HashSet class

        Console.WriteLine("Enter the Elements of myhash1:");        
        hash1.Add(Console.ReadLine());                              // Add the elements in HashSet  Taking input through user with the help of Add method
        hash1.Add(Console.ReadLine());
        hash1.Add(Console.ReadLine());
        hash1.Add(Console.ReadLine());
        hash1.Add(Console.ReadLine());
        Console.WriteLine("Elements of myhash1:");  // Accessing elements of HashSet
       
        foreach (var val in hash1)                   // Using foreach loop
        {
            Console.WriteLine(val);                  // Display elements of myhash1 one bye one
        }

        Console.ReadLine();
    }
}