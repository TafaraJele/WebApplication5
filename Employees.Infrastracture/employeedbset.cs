using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWrite.Models
{
    public class Employeedbset : IEmployeeRepository
{

    public string EmployeeCollectionName  { get; set; }

        public string QualificationCollectionName { get; set; }

        public string ConnectionString { get; set; }

    public string DatabaseName { get; set; }
}

public interface IEmployeeRepository
{
    string EmployeeCollectionName { get; set; }

    string QualificationCollectionName { get; set; }

    string ConnectionString { get; set; }

    string DatabaseName { get; set; }

}
}
