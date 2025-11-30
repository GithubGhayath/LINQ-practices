using Repository.Entities;
using Repository.Extensions;
using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethod
{
    internal class CustomLINQExtensionMethodProgram
    {
        public static void Main(string[] args)
        {
            var Emps = Employees.GenerateEmployees(100);

            // Normal paginate() 

            //    Console.WriteLine("First Page:\n");
            //    Emps.Paginate1(1, 10).ToList().ForEach(e => Console.WriteLine(e));
            //    Console.WriteLine("\n\nSecond Page:\n");
            //    Emps.Paginate1(2, 10).ToList().ForEach(e => Console.WriteLine(e));
            //    Console.WriteLine("\n\nThird Page:\n");
            //    Emps.Paginate1(3, 10).ToList().ForEach(e => Console.WriteLine(e));


            // Fail scenerois:

            // Emps.Paginate1(0, 10).ToList().ForEach(e => Console.WriteLine(e));
            // Emps.Paginate1(1, 0).ToList().ForEach(e => Console.WriteLine(e));
            // Emps.Paginate1(-1, 10).ToList().ForEach(e => Console.WriteLine(e));
            // Emps.Paginate1(1, -1).ToList().ForEach(e => Console.WriteLine(e));

            Console.WriteLine("First Page Employees with pension plan:\n");
            Emps.WhereWithPaginate((x => x.HasPensionPlan == true), 1, 10).ToList().ForEach(e => Console.WriteLine(e)); ;


            Console.WriteLine("\n\n--------------------------------------------------------\n\n");

            Console.WriteLine("\n\nFirst page Employees with Health Insurance:");
            Emps.WhereWithPaginate((e => e.HasHealthInsurance == true), 1, 10).ToList().ForEach(e => Console.WriteLine(e)); 


            Console.WriteLine("\n\nSecond page Employees with Health Insurance:");
            Emps.WhereWithPaginate((e => e.HasHealthInsurance == true), 2, 10).ToList().ForEach(e => Console.WriteLine(e));


            Console.WriteLine("\n\nThird page Employees with Health Insurance:");
            Emps.WhereWithPaginate((e => e.HasHealthInsurance == true), 3, 10).ToList().ForEach(e => Console.WriteLine(e));


            Console.WriteLine("\n\nFourth page Employees with Health Insurance:");
            Emps.WhereWithPaginate((e => e.HasHealthInsurance == true), 4, 10).ToList().ForEach(e => Console.WriteLine(e));

        }
    }
}
