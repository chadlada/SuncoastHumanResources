using System.Collections.Generic;
using System.Linq;

namespace SuncoastHumanResources
{
    class EmployeeDatabase
    {
        // var employees = new List<Employee>();
        private List<Employee> Employees { get; set; } = new List<Employee>();

        // method to load employees
        public void LoadEmployees()
        {

        }

        public void SaveEmployees()
        {

        }

        // CREATE Add Employee
        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        // READ Get All Employees
        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        // READ Find One Employee
        public Employee FindOneEmployee(string nameToFind)
        {
            Employee foundEmployee = Employees.FirstOrDefault(employee => employee.Name.ToUpper().Contains(nameToFind.ToUpper()));

            return foundEmployee;
        }


        // DELETE Delete Employee
        public void DeleteEmployee(Employee employeeToDelete)
        {
            Employees.Remove(employeeToDelete);
        }

        // UPDATE??

    }
}
