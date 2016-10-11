using System;
using System.Collections.Generic;

namespace Mocking
{
    public class Employee : IEmployeeRepository
    {
        public int Id { get; internal set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public int Wage { get; internal set; }

        public double CalculateWeeklySalary(int hours, int wage)
        {
            return hours * wage;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int CountEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee CreateEmployee(string name, string type)
        {
            throw new NotImplementedException();
        }

        public List<Employee> FindAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee LoadEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}