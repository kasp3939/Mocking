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

        Dictionary<long, Employee> database = new Dictionary<long, Employee>();

        public double CalculateWeeklySalary(int hours, int wage)
        {
            return hours * wage;
        }

        public void Clear()
        {
            database.Clear();
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
            if (database.ContainsKey(id)) return database[id];
            else return null;
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}