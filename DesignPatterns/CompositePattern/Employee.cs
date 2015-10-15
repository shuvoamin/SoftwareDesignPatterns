using System.Collections.Generic;

namespace DesignPatterns.CompositePattern
{
    public class Employee
    {
        private string _name;
        private string _dept;
        private int _salary;
        private List<Employee> _subOrdinates;

        public Employee(string name, string dept, int salary) 
        {
            _name = name;
            _dept = dept;
            _salary = salary;
            _subOrdinates = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            _subOrdinates.Add(employee);
        }

        public void Remove(Employee employee)
        {
            _subOrdinates.Remove(employee);
        }

        public List<Employee> GetAllEmployee()
        {
            return _subOrdinates;
        }

        public override string ToString() 
        {
            return ("Employee :[ Name : " + _name + ", dept : " + _dept + ", salary :" + _salary+" ]");
        }
    }
}
