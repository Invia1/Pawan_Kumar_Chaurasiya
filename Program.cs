using System;
using System.Collections.Generic;

class GenericListFuncitonality
{
    List<string> genlist = new List<string>();

    public void addlst()
    {
        Console.WriteLine("\n--------------------Adding the element into the Generic list-------------------------------");
        genlist.Add("VIVEK");
        genlist.Add("MANOJ");
        genlist.Add("AARTI");
        genlist.Add("POOJA");
        genlist.Add("AMIT");


        foreach (var ctr in genlist)
        {
            Console.WriteLine(ctr);

        }
        Console.WriteLine("----------------total element after Addition  " + genlist.Count + "-----------------------");
    }
    public void insertlst()
    {
        Console.WriteLine("\n---------------------Inserting the element into the Generic List---------------------------");
        genlist.Insert(1, "Virender");
        genlist.Insert(2, "Somdutt");
        genlist.Insert(7, "Umeshkumar");


        foreach (var ctr in genlist)
        {
            Console.WriteLine(ctr);
        }
        Console.WriteLine("-------------------Total element after Insertion  " + genlist.Count + "--------------------");
    }

    public void deletelst()
    {
        Console.WriteLine("\n-------------------Deleting the element from the Generic List---------------------");
        genlist.Remove("Virender");
        genlist.RemoveAt(0);

        foreach (var ctr in genlist)
        {
            Console.WriteLine(ctr);
        }
        Console.WriteLine("----------------Total element after Deletion  " + genlist.Count + "-------------------");
    }
    public void updatelst()
    {
        Console.WriteLine("\n----------Updating the element from Generic List via Indexing and via name -------------");

        genlist.RemoveAt(7);
        genlist.Remove("Somdutt");
        genlist.Insert(5, "Anupriya");
        genlist.Insert(3, "Deepanjali");

        foreach (var ctr in genlist)
        {
            Console.WriteLine(ctr);
        }
        Console.WriteLine("--------------------Total element after updation " + genlist.Count + "--------------------");
    }
    public void searchlst()
    {
        Console.WriteLine("\n-----------------------Inserting the element into the Generic List------------------");
        var a = genlist.Contains("POOJA");
        if (a == true)
        {
            Console.WriteLine("The enter value is present in array");
        }
        else
        {
            Console.WriteLine("Entered value is not present in array");
        }

    }
    public void Fetchalllst()
    {
        Console.WriteLine("\n------------All the element into the Generic List through Fetching----------------");
        foreach (var store in genlist)
        {
            Console.WriteLine(store);
        }
        Console.WriteLine("---------------Total element after Fetching all " + genlist.Count + "------------------");
    }
}


class user
{
    public static void Main()
    {
        var obj = new GenericListFuncitonality();
        obj.addlst();
        obj.insertlst();
        obj.updatelst();
        obj.deletelst();
        obj.Fetchalllst();
        obj.searchlst();
        Console.ReadLine();

    }
}