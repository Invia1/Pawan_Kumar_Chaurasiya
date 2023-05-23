using System;
using System.Collections.Generic;
using RIM_Hospital.Model;
using RIM_Hospital.InterfacePatient;


namespace RIM_Hospital.Funtionality
{
    class PatientOperation : INterfacePat  //adding interace 
    {

        Dictionary<int, PatientDec> PatientList = new Dictionary<int, PatientDec>();  //Creating the dictionary 

        public void PatientRegistration()      //Create Patient Registration Function to Store the data 
        {
            PatientDec obj = new PatientDec();

            Console.WriteLine("***** Welcome to RIM Hospital *****\n");



            Console.Write("Enter the First name: ");
            obj.First_name = (Console.ReadLine());          // Taking input through user
            Console.Write("Enter the Middle Name: ");
            obj.Middle_name = (Console.ReadLine());
            Console.Write("Enter the Last Name: ");
            obj.Last_name = (Console.ReadLine());
            while (true)                                        //Validation using While and if else 
            {
                Console.Write("Enter the Phone No: ");
                obj.Phone_No = double.Parse(Console.ReadLine());
                if (obj.Phone_No.ToString().Length != 10)
                {
                    Console.WriteLine(obj.Phone_No + " Invalid phone no.");
                }
                else
                {
                    break;
                }
            }

            
            while (true)
            {
                Console.Write("Enter your Gender(Male / Female / Other: ");
                obj.Gender = (Console.ReadLine());
                if (obj.Gender =="male" || obj.Gender == "female" || obj.Gender == "other" ||obj.Gender == "Male" || obj.Gender == "Female" || obj.Gender == "Other")
                {
               
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }

            while (true)
            {
                Console.Write("Enter the Paitent Age (Between 10-99): ");
                obj.Patient_Age = int.Parse(Console.ReadLine());

                if (obj.Patient_Age.ToString().Length != 2)
                {
                    Console.WriteLine(obj.Patient_Age + " is an Invalid Age.  ");
                }

                else
                {
                    break;
                }
            }
            Console.Write("Enter the Paitent Address: ");
            obj.Patient_Address = (Console.ReadLine());

            while (true)
            {
                Console.Write("Enter the Aaddhar Number(12 Digit): ");
                obj.Patient_AaddharNo = double.Parse(Console.ReadLine());
                if (obj.Patient_AaddharNo.ToString().Length != 12)
                {
                    Console.WriteLine(obj.Patient_AaddharNo + " Invalid Aaddhar no.");
                }
                else
                {
                    break;
                }
            }


            while (true)
            {

                Console.Write("Enter the Patient to be Consulted from which Department(Dental/Orthopaedics/General Medicine): ");
                obj.Patient_to_Consulted = (Console.ReadLine());
                if (obj.Patient_to_Consulted == "Orthopaedics" || obj.Patient_to_Consulted == "Dental" || obj.Patient_to_Consulted == "General Medicine" || obj.Patient_to_Consulted == "orthopaedics" || obj.Patient_to_Consulted == "dental" || obj.Patient_to_Consulted == "general medicine")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            PatientList.Add(PatientList.Count + 1, obj);   
        }

        public Dictionary<int, PatientDec> GetPatient()
        {
            return PatientList;
        }

        public PatientDec GetPatientById(int id)
        {
            return PatientList[id];  // Show the details of the Patient with the help of ID
        
        }


    }
}
