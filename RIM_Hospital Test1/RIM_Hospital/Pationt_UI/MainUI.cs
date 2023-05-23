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
            INterfacePat pt = new PatientOperation();

            while (true)
            {
                
                Console.WriteLine("***** Welcome to RIM Hospital *****\n");
                Console.WriteLine("Select from given options :");
                Console.WriteLine("1 - Patient registration");
                Console.WriteLine("2 - Show all patient");
                Console.WriteLine("3 - Show patient by id");
                Console.WriteLine();
                int selectedValue = int.Parse(Console.ReadLine());   
                Console.Clear();
                switch (selectedValue)
                {
                    case 1:
                        pt.PatientRegistration();
                        break;
                    case 2:
                        Dictionary<int, PatientDec> objList = pt.GetPatient();
                        Console.WriteLine(" \nThe Whole Data of the Patient is as below:- \n");
                        foreach (var data in objList)
                        {

                            Console.WriteLine("Patient Registration id :- " + data.Key + "\nFull Name :- " + data.Value.First_name + " " + data.Value.Middle_name + " " + data.Value.Last_name + "\nMobile No :- " + data.Value.Phone_No + "\nGender :- " + data.Value.Gender + "\nPat. Age :- " + data.Value.Patient_Age + "\nAddress :- " + data.Value.Patient_Address + "\n Addhar No :- " + data.Value.Patient_AaddharNo + "\nCounsultation :- " + data.Value.Patient_to_Consulted);
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please enter patient id:");
                        int id = int.Parse(Console.ReadLine());
                        PatientDec patientById = pt.GetPatientById(id);
                        Console.WriteLine("Entered " + id + " details are as follows :-");
                        Console.WriteLine("Patient Registration id :- " + id + "\nFull Name :- " + patientById.First_name + " " + patientById.Middle_name + " " + patientById.Last_name + "\nMobile No :- " + patientById.Phone_No + "\nGender :- " + patientById.Gender + "\nPat. Age :- " + patientById.Patient_Age + "\nAddress :- " + patientById.Patient_Address + "\n Addhar No :- " + patientById.Patient_AaddharNo + "\nCounsultation :- " + patientById.Patient_to_Consulted);
                        break;

                    

                    default:
                        Console.WriteLine("Invalid selection");
                        break;

                }

            }
        }
    }
}
