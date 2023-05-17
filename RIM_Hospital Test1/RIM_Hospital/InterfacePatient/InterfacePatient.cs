using System;
using System.Collections.Generic;
using RIM_Hospital.Model;
using RIM_Hospital.Funtionality;


namespace RIM_Hospital.InterfacePatient
{
    interface InterfacePat
    {
       
        List<PatientDec> GetPatient();
        List<PatientDec> PatientRegistration(PatientDec plr);
    }
}
