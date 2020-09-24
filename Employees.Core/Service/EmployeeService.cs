using EmployeesWrite.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EmployeesWrite.Service
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IMongoCollection<Employee> _employee;
        private readonly IMongoCollection<EmployeeQualification> _qualification;

        public EmployeeService(Models.IEmployeeRepository settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employee = database.GetCollection<Employee>(settings.EmployeeCollectionName);
            _qualification = database.GetCollection<EmployeeQualification>(settings.QualificationCollectionName);


        }
        public List<Employee> GetEmployees() =>


                _employee.Find(employee => true).ToList();

        public Employee Get(Guid Id)
        {

            return _employee.Find(e => e.Id == Id).FirstOrDefault();


        }
        public Employee Create(Employee employee)

        {
            employee.Id = Guid.NewGuid();

            _employee.InsertOne(employee);


            return employee;

        }

        public List<EmployeeQualification> GetEmployeeQualifications() =>

           _qualification.Find(qualification => true).ToList();

        public EmployeeQualification Create(EmployeeQualification employeeQualification)
        {
            _qualification.InsertOne(employeeQualification);

            return employeeQualification;


        }



        /*public Employee DeleteEmployee(Guid Id, Employee employee)
        {

           var employees = _employee.Find(e => e.Id == Id).FirstOrDefault(); 

                {
                employee.Id = Guid.NewGuid();
                _employee.DeleteOne(employee);

                return employee;

            }

          
        */
    }
}







