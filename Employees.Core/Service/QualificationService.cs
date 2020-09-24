﻿using EmployeesWrite.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWrite.Service
{
    public class QualificationService
    {
        private readonly IMongoCollection<EmployeeQualification> _qualification;

        public QualificationService(Models.IEmployeeRepository settings)
        {
            var client = new MongoClient(settings.ConnectionString);

            var database = client.GetDatabase(settings.DatabaseName);

            _qualification = database.GetCollection<EmployeeQualification>(settings.QualificationCollectionName);
        }

        public List<EmployeeQualification> GetEmployeeQualifications() =>

            _qualification.Find(qualification => true).ToList();

        public EmployeeQualification Create(EmployeeQualification employeeQualification)
        {
            _qualification.InsertOne(employeeQualification);

            return employeeQualification;


        }




    }
}
