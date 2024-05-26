using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using TCPData;
using TCPExtensions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Company_LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Employee> employees = Data.GetEmployees();
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Fname} {employee.Lname} Annual Salary: {employee.AnnualSalary}");
            }*/

            /*List<Employee> empList = Data.GetEmployees();
            var filteredEmployees = empList.Filter(x => x.IsManager == true);
            foreach (Employee employee in filteredEmployees)
            {
                Console.WriteLine($"{employee.Fname} {employee.Lname} Annual Salary: {employee.AnnualSalary}");
            }*/

            /*List<Employee> empList = Data.GetEmployees();
            var filteredEmployees = empList.Where(x => x.IsManager == true);
            foreach (Employee employee in filteredEmployees)
            {
                Console.WriteLine($"{employee.Fname} {employee.Lname} Annual Salary: {employee.AnnualSalary}");
            }*/

            List<Employee> empList1 = Data.GetEmployees();
            List<Department> deptList1 = Data.GetDepartments();

            /*var result = from a in empList1
                         join b in deptList1
                         on a.DepartmentId equals b.Id
                         select new
                         {
                             id = a.Id,
                             FirstName = a.Fname,
                             LastName = a.Lname,
                             Department = b.LongName

                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} works in {item.Department}");
            }

            var avgAnnualSalary = empList1.Average(x => x.AnnualSalary);
            var maxAnnualSalary = empList1.Max(x => x.AnnualSalary);
            var lowestAnnualSalary = empList1.Min(x => x.AnnualSalary);

            var totalAnnualSalary = empList1.Sum(x => x.AnnualSalary);

            Console.WriteLine($"Average Annual Salary: {avgAnnualSalary}");
            Console.WriteLine($"Max Annual Salary: {maxAnnualSalary}");
            Console.WriteLine($"Lowest Annual Salary: {lowestAnnualSalary}");
            Console.WriteLine($"Total Annual Salary: {totalAnnualSalary}");*/


            //Method Syntax
            /*var result = empList1.Select(x => new
            {
                FullName = $"{x.Fname} {x.Lname}",
                Salary = x.AnnualSalary
            }).Where(e => e.Salary >= 75000);*/

            //Query Syntax
            /*var result = from emp in empList1
                         where emp.AnnualSalary >= 75000
                         select new
                         {
                             FullName = $"{emp.Fname} {emp.Lname}",
                             Salary = emp.AnnualSalary
                         };*/

            //Join inner

            /*var result = from emp in empList1
                         join dept in deptList1
                         on emp.DepartmentId equals dept.Id
                         select new
                         {
                             FullName = $"{emp.Fname} {emp.Lname}",
                             Salary = emp.AnnualSalary
                         };
           

            foreach(var a in result)
            {
                Console.WriteLine($"{a.FullName,-20} Annual Salary: {a.Salary-20}");
            }*/

            //Group Join --Left Outer Join
            /*var result = from dept in deptList1
                         join emp in empList1
                         on dept.Id equals emp.DepartmentId
                         into empGroup
                         select new
                            {
                                Department = dept.LongName,
                                Employees = empGroup
                            };

            foreach(var items in result)
            {

               Console.WriteLine($"Department: {items.Department}");
                foreach(var emp in items.Employees)
                {
                    Console.WriteLine($"\t{emp.Fname} {emp.Lname}");
                }
            }*/

            //Operatore
            //Grouping

            /*var result = from emp in empList1
                         group emp by emp.DepartmentId
                         into empGroup
                         select new
                            {
                                DepartmentId = empGroup.Key,
                                Employees = empGroup
                            };

            foreach (var items in result)
            {
                Console.WriteLine($"Department: {items.DepartmentId}");
                foreach (var emp in items.Employees)
                {
                    Console.WriteLine($"\t{emp.Fname} {emp.Lname}");
                }
            }*/


            /*            Sorting Operators
            OrderBy
            OrderByDescendng
            ThenBy
            TherByDescendng
            Grouping Operators
            GroupBy
            ToLookup
            Quantifier Operators
            Any
            Contans
            Filter Operators
            OfType
            Where
            Element Operators
            ElementAt
            ElementAtOrDefautt
            First
            FirstOrDefaUt
            Last
            lastordefault
            Single
            SingleOrDefault
            r:23 • Operators >*/

            //OrderBY & thenBy
            /*var results = from emp in empList1
                          orderby emp.Fname, emp.Lname
                          select emp;
            foreach (var emp in results)
            {
                Console.WriteLine($"{emp.Fname} {emp.Lname}");
            }*/

            /*var results = from emp in empList1
                          join dept in deptList1
                          on emp.DepartmentId equals dept.Id
                          orderby emp.DepartmentId, emp.AnnualSalary descending
                          select new
                            {
                                FullName = $"{emp.Fname} {emp.Lname}",
                                Department = dept.LongName,
                                Salary = emp.AnnualSalary
                            };
            foreach(var emp in results)
            {
                Console.WriteLine($"{emp.FullName,-20} {emp.Department,-20} {emp.Salary}");
            }*/



            ////All, Any, Contains Quantifier Operators
            ////All and Any Operators
            //var annualSalaryCompare = 40000;

            //bool isTrueAll = empList1.All(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAll)
            //{
            //    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Not all employee annual salaries are above {annualSalaryCompare}");
            //}

            //bool isTrueAny = empList1.Any(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAny)
            //{
            //    Console.WriteLine($"At least one employee has an annual salary above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"No employees have an annual salary above {annualSalaryCompare}");
            //}

            //Contains Operator
            //    var searchEmployee = new Employee
            //    {
            //        Id = 3,
            //        Fname = "Diksha",
            //        Lname = "Mehta",
            //        AnnualSalary = 75000.3m,
            //        IsManager = true,
            //        DepartmentId = 3
            //    };

            //    bool containsEmployee = empList1.Contains(searchEmployee, new EmployeeComparer()); //will not work ,we have to tell compiler how to compare user defined data to emp list data; 
            //    //we have to make comparer class which inherits IEwualityComparer<Employee> interface

            //    if (containsEmployee)
            //    {
            //        Console.WriteLine($"An employee record for {searchEmployee.Fname} {searchEmployee.Lname} was found");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"An employee record for {searchEmployee.Fname} {searchEmployee.Lname} was not found");
            //    }
            //}



            ////OfType filter Operator
            //ArrayList mixedCollection = GetHeterogeneousDataCollection();

            //var stringResult = from s in mixedCollection.OfType<string>()
            //                   select s;

            //var intResult = from i in mixedCollection.OfType<int>()
            //                select i;


            //foreach (var item in intResult)
            //    Console.WriteLine(item);

            //var employeeResults = from e in mixedCollection.OfType<Employee>()
            //                      select e;

            //foreach (var emp in employeeResults)
            //    Console.WriteLine($"{emp.Id,-5} {emp.Fname,-10} {emp.Lname,-10}");

            //var departmentResults = from d in mixedCollection.OfType<Department>()
            //                        select d;

            //foreach (var dept in departmentResults)
            //    Console.WriteLine($"{dept.Id,-5} {dept.LongName,-30} {dept.ShortName,-10}");



            ////ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single and SingleOrDefault Element Operators
            ////ElementAt, ElementAtOrDefault Operators
            //var emp = empList1.ElementAtOrDefault(1);

            //if (emp != null)
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.Fname,-10} {emp.Lname,-10}");
            //}
            //else
            //{
            //    Console.WriteLine("This employee record does not exist within the collection");
            //}

            ////First, FirstOrDefault, Last, LastOrDefault Operators
            List<int> integerList = new List<int> { 3, 13, 23, 17, 26, 87, 48 };

            ////int result = integerList.First(i => i % 2 == 0);
            //// int result = integerList.FirstOrDefault(i => i % 2 == 0);
            //int result = integerList.LastOrDefault(i => i % 2 == 0);

            //if (result != 0)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("There are no even numbers in the collection");
            //}


            decimal totalSalary = empList1.Aggregate<Employee, decimal>(0, (totalSalary, e) =>
            {
                var bonous = (e.IsManager) ? 0.04m : 0.01m;

                return totalSalary += e.AnnualSalary + (e.AnnualSalary * bonous) + totalSalary;
            });

            Console.WriteLine($"Total Salary: {totalSalary}");

        }

        public static ArrayList GetHeterogeneousDataCollection()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(100);
            arrayList.Add("Bob Jones");
            arrayList.Add(2000);
            arrayList.Add(3000);
            arrayList.Add("Bill Henderson");
            arrayList.Add(new Employee { Id = 6, Fname = "Jennifer", Lname = "Dale", AnnualSalary = 90000, IsManager = true, DepartmentId = 1 });
            arrayList.Add(new Employee { Id = 7, Fname = "Dane", Lname = "Hughes", AnnualSalary = 60000, IsManager = false, DepartmentId = 2 });
            arrayList.Add(new Department { Id = 4, ShortName = "MKT", LongName = "Marketing" });
            arrayList.Add(new Department { Id = 5, ShortName = "R&D", LongName = "Research and Development" });
            arrayList.Add(new Department { Id = 6, ShortName = "PRD", LongName = "Production" });

            return arrayList;
        }

        public class EmployeeComparer : IEqualityComparer<Employee>
        {
            public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
            {
                if (x.Id == y.Id && x.Fname.ToLower() == y.Fname.ToLower() && x.Lname.ToLower() == y.Lname.ToLower())
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode([DisallowNull] Employee obj)
            {
                return obj.Id.GetHashCode();
            }
        }
    }
}
