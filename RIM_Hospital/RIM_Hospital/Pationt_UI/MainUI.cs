using System;
using System.Collections.Generic;
using RIM_Hospital.Model;
using RIM_Hospital.Funtionality;
using RIM_Hospital.InterfacePatient;



namespace RIM_Hospital.Pationt_UI
{
    class MainUI
    {
        

        public static void Main()
            {



            PatientDec obj = new PatientDec();
            Console.Write("Enter the ID Number Not Less Than 3 Number: ");
            obj.Patient_Registration_ID = int.Parse(Console.ReadLine());
            Console.Write("Enter the First name: ");
            obj.First_name = (Console.ReadLine());
            Console.Write("Enter the Middle Name: ");
            obj.Middle_name = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            obj.Last_name = Console.ReadLine();
            Console.Write("Enter the Phone No: ");
            obj.Phone_No = int.Parse( Console.ReadLine());
            Console.Write("Enter your Gender ");
            obj.Gender = (Console.ReadLine());
            Console.Write("Enter the Patient Age in year(Number Form): ");
            obj.Patient_Age = int.Parse(Console.ReadLine());
            Console.Write("Enter the Paitent Address: ");
            obj.Patient_Address = Console.ReadLine();
            Console.Write("Enter the Aaddhar Number: ");
            obj.Patient_AaddharNo = int.Parse( Console.ReadLine());
            Console.Write("Enter the Patient to be Consulted from which Department: ");
            obj.Patient_to_Consulted = Console.ReadLine();

            
            InterfacePat pt = new PatientOperation();
            pt.PatientRegistration(obj);
            

            List<PatientDec> objList = pt.GetPatient();
            foreach (var data in objList)
            {
                Console.WriteLine(" \nThe Whole Data of the Patient is as below:- \n");
                Console.WriteLine("Patient Registration id :- "+data.Patient_Registration_ID + "\nFull Name :- " + data.First_name + " " + data.Middle_name + " " + data.Last_name + "\nMobile No :- " + data.Phone_No+"\nGender :- " + data.Gender + "\nPat. Age :- " + data.Patient_Age + "\nAddress :- " + data.Patient_Address + "\n Addhar No :- " + data.Patient_AaddharNo + "\nCounsultation :- " + data.Patient_to_Consulted);
                Console.ReadLine();
                break;
            }
            Console.WriteLine(" The Whole Data of the Patient is as below:- ");
            
            Console.ReadLine();


        }
    }
}