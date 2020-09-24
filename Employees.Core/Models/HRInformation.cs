using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmployeesWrite.Models
{
    [DataContract]
    public class HRInformation
    { 

        [DataMember (Name ="ecNumber")]
        public int ECnumber { get; set; }

        [DataMember (Name = "salary")]
        public int Salary { get; set; }

        [DataMember (Name= "medicalAidType")]
        public int MedicalAidType { get; set; }

        [DataMember (Name= "employeeCategory")]
        public string EmployeeCategory { get; set; }


    }
}
