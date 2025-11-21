using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifiersStatements
{
    internal class QuantifiersStatementsProgram
    {
        public static void Main(string[]args)
        {
            var emps = Employees.GetEmployees();
            string Result = string.Empty;


            // Any() returns true or false base on condition if any item that matches the expression returns true otherways returns false   BIG(O) == O(n)
            bool IsThereSalaryBiggerThan4000 = emps.Any(e => e.Salary > 4_000);
            SupportedMethod(IsThereSalaryBiggerThan4000, new string[] { "Yes there is an employee has salary bigger than 4_000", "No there is no an employee has salary bigger than 4_000" });
           


            bool IsThereSalaryBiggerThan1000000 = emps.Any(e => e.Salary > 1_000_000);
            SupportedMethod(IsThereSalaryBiggerThan1000000, new string[] { "Yes there is an employee has salary bigger than 1_000_000" , "No there is no an employee has salary bigger than 1_000_000" });



            // All() returns true if all items match the expression  otherways returns false  BIG(O) == O(n)
            bool DoAllEmployeesHaveSkills = emps.All(e => e.Skills.Count > 0);
            SupportedMethod(DoAllEmployeesHaveSkills, new string[] { "Yes employees have Skills" , "no some employees don't Skills" });
          

            bool DoAllEmployeesOlderThan25 = emps.All(e => e.Age > 25);
            SupportedMethod(DoAllEmployeesOlderThan25, new string[] { "Yes all employees older than 25" , "no some employees don't older than 25" });
           

          

        }

        public static void SupportedMethod(bool Result, string[] messages)
        {
            string ToPrint = Result ? messages[0] : messages[1];
            Console.WriteLine(ToPrint);
        }
    }
}
