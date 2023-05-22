using System;
using System.Collections.Generic;

namespace Dictionary.User_UI
{
    class Main_UI
    {
        Dictionary<int, string> DicList = new Dictionary<int, string>();



        public void Addfunc()
        {
            DicList.Add(1,"Pawan");
            DicList.Add(2, "Saroj");
            DicList.Add(3, "Manoj");
            DicList.Add(4, "Vinod");
            DicList.Add(5, "Aman");

        }
        public Dictionary<int,string> Show_Record()
        {
            return DicList;
        }
        public static void Main()
        {
            Console.WriteLine("Welcome to Dictionery Program");

            Main_UI er = new Main_UI();
            er.Addfunc();
            Console.WriteLine("Total number of Record Found");
            er.Show_Record();
            foreach (var item in er.DicList)
            {
                Console.WriteLine("Emp Id is :- "+item.Key+", EmpName is :- "+item.Value);
            }
            
            

            Console.ReadLine();
            



        }


    }
}
