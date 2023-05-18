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
            
            
      \\      foreach (var item in PatientList)
          \\  {
         \\       if (plr!=item)
         \\       {
          \\          PatientList.Add(plr);
         \\           Console.WriteLine("The details are saved");
          \\          break;

         \\       }
         \\       if (plr == item)
         \\       {
         \\           Console.WriteLine("Enter the Fresh Data");

         \\       }

         \\   }

                return PatientList;
            }
        public List<PatientDec> GetPatient()
            { 
                return PatientList;
            }        
    }
}


