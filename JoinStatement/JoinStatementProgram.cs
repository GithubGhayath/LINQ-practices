using Repository.Entities;
using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinStatement
{
    public class EmployeesDto
    {
        public string? Department { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"{Name} [{Department}]";
        }
    }
    public class GroupEmployeeDto
    {
        public string? Department { get; set; }
        public List<string>? Names { get; set; }

        public override string ToString()
        {
            string EmployeesNames = string.Empty;

            foreach (var name in Names)
            {
                EmployeesNames += $"{name}\n";
            }
            

            return $"Department: {Department}\n{EmployeesNames}\n\n";
        }
    }

    internal class JoinStatementProgram
    {
        public static void Main(string[]args)
        {
           // RunJoin();
            RunGroupJoin();
        }

        public static void RunJoin()
        {
            var EmployeesDataSource = Employees.GetEmployees();
            var DepartmentDataSource = Departments.GetDepartments();


            var Result = EmployeesDataSource.Join(
                DepartmentDataSource,
                emps => emps.DepartmentId,
                deps => deps.Id,
                (emps, deps) => new EmployeesDto
                {
                    Name = emps.Name,
                    Department = deps.Name
                }).ToList();

            Result.ForEach(emp => Console.WriteLine(emp));
        }

        public static void RunGroupJoin()
        {
            var EmployeesDataSource = Employees.GetEmployees();
            var DepartmentDataSource = Departments.GetDepartments();


            var Result = DepartmentDataSource.GroupJoin(
                EmployeesDataSource,
                dept => dept.Id,
                emp => emp.DepartmentId,
                (dep, emp) => new GroupEmployeeDto
                {
                    Department = dep.Name,
                    Names = emp.Select(e=>e.Name).ToList()
                }).ToList();

            Result.ForEach(emp => Console.WriteLine(emp));
        }
    }
}
