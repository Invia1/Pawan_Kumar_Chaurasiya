using System;
using System.Collections.Generic;
using RIM_Hospital.Model;
using RIM_Hospital.InterfacePatient;


namespace RIM_Hospital.Funtionality
{
    class PatientOperation:InterfacePat
    {
        
            List<PatientDec> PatientList = new List<PatientDec>();

        public List<PatientDec> PatientRegistration(PatientDec plr)
        {
            
            
            foreach (var item in PatientList)
            {
                if (plr!=item)
                {
                    PatientList.Add(plr);
                    Console.WriteLine("The details are saved");
                    break;

                }
                if (plr == item)
                {
                    Console.WriteLine("Enter the Fresh Data");

                }

            }

                return PatientList;
            }
        public List<PatientDec> GetPatient()
            { 
                return PatientList;
            }        
    }
}


//public void RemovePlayer(int a)
//{
//    int b = 0;

//    foreach (var item in objList)
//    {

//        if (item.Player_No == a)
//        {
//            objList.Remove(item);
//            b++;

//            Console.Write("\nThe Element is deleted from the list and ");

//            break;
//        }


//    }
//    if (b == 0)
//    {

//        Console.WriteLine("Entered Element is not found");
//        Console.WriteLine();
//    }


//}

//public void UpdatePlayer(int a)
//{
//    int b = 0;

//    foreach (var item in objList)
//    {

//        if (item.Player_No == a)
//        {
//            item.Player_name = "Messy";
//            b++;
//            Console.Write("\nPlayer Name has been updated in the list and");
//            break;
//        }


//    }
//    if (b == 0)
//    {

//        Console.WriteLine("Player name is not found");
//        Console.WriteLine();
//    }


//}

//public void FindPlayer(int a)
//{
//    int b = 0;

//    foreach (var item in objList)
//    {

//        if (item.Player_No == a)
//        {

//            Console.Write("\nPlayer name is found in the list and the name of the player is " + a);
//            break;
//        }


//    }
//    if (b == 0)
//    {

//        Console.WriteLine("Player name is not found or player is not the part of team");
//        Console.WriteLine();
//    }


//}