using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace SuncoastHumanResources
{
    class EmployeeDatabase
    {
        // var employees = new List<Employee>();
        private List<Employee> Employees { get; set; } = new List<Employee>();

        // method to load employees
        public void LoadEmployees()
        {
            if (File.Exists("employees.csv"))
            {
                var fileReader = new StreamReader("employees.csv");
                var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

                // Replace our BLANK list of employees with the ones that are in the CSV file
                Employees = csvReader.GetRecords<Employee>().ToList();
                fileReader.Close();
            }
        }

        public void SaveEmployees()
        {
            var fileWriter = new StreamWriter("employees.csv");
            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(Employees);
            fileWriter.Close();
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
