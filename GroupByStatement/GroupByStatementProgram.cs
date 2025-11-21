using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByStatement
{
    internal class GroupByStatementProgram
    {
        public static void Main(string[] args)
        {
            GroupEmployeeBasedOnDepartmentUsingGroupByMethod();
            GroupEmployeeBasedOnDepartmentUsingToLookUpMethod();
        }

        public static void GroupEmployeeBasedOnDepartmentUsingGroupByMethod()
        {
            var emps = Employees.GetEmployees();


            // GroupBy() uses deferred execution. ==> use when Single process.
            var Groups = emps.GroupBy(e => e.DepartmentId);

            Console.WriteLine($"\n\n\n=====================================Group By=====================================");
            foreach(var Group in Groups)
            {
                Console.WriteLine($"\n\n---------------------------Department: {Group.Key}---------------------------");
                Group.ToList().ForEach(e => Console.WriteLine(e));
                Console.WriteLine($"----------------------------------------------------------------------------");

            }
        }

        public static void GroupEmployeeBasedOnDepartmentUsingToLookUpMethod()
        {
            var emps = Employees.GetEmployees();

            // ToLookup() uses immediate execution. ==> use when multiple process.
            var GroupEmployeeBasedOnDepartment = emps.ToLookup(e => e.DepartmentId);

            Console.WriteLine($"\n\n\n=====================================To look up=====================================");
            foreach (var item in GroupEmployeeBasedOnDepartment)
            {
                Console.WriteLine($"\n\n---------------------------Department: {item.Key}---------------------------");
                item.ToList().ForEach(e => Console.WriteLine(e));
                Console.WriteLine($"----------------------------------------------------------------------------");

            }
        }
    }
}
