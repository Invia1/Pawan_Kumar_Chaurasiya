using System;
using System.Collections.Generic;
using RIM_Hospital.Model;
using RIM_Hospital.Funtionality;


namespace RIM_Hospital.InterfacePatient
{
    interface INterfacePat
    {

        Dictionary<int, PatientDec> GetPatient();  //Calling the function to show the patient list 

        void PatientRegistration();                 //Calling the function to registered in the patient list 

        PatientDec GetPatientById(int id);            //Calling the function to registered in the patient list 


    }
}
