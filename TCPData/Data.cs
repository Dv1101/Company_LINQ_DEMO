using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> EmployeesList = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                Fname = "John",
                Lname = "Doe",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 1
            };
            EmployeesList.Add(employee);
            employee = new Employee
            {
                Id = 2,
                Fname = "Dhruv",
                Lname = "Varia",
                AnnualSalary = 100000.3m,
                IsManager = true,
                DepartmentId = 1
            };
            EmployeesList.Add(employee);
            employee = new Employee
            {
                Id = 3,
                Fname = "Dhairya",
                Lname = "Amin",
                AnnualSalary = 50000.3m,
                IsManager = false,
                DepartmentId = 2
            };
            EmployeesList.Add(employee);
            employee = new Employee
            {
                Id = 3,
                Fname = "Diksha",
                Lname = "Mehta",
                AnnualSalary = 75000.3m,
                IsManager = true,
                DepartmentId = 3
            };
            EmployeesList.Add(employee);
            employee = new Employee
            {
                Id = 4,
                Fname = "Upal",
                Lname = "Vasava",
                AnnualSalary = 39000.3m,
                IsManager = false,
                DepartmentId = 1
            };
            EmployeesList.Add(employee);


            return EmployeesList;
        }
        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"
            };
            departments.Add(department);

            return departments;
        }

    }
}
