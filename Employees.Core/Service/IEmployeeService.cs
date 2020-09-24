﻿using EmployeesWrite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWrite.Service
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee Get(Guid Id);

        Employee Create(Employee employee);
    }
}
