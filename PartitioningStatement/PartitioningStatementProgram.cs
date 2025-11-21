using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Repository.Entities;
using Repository.Repos;


namespace PartitioningStatement
{
    internal class PartitioningStatementProgram
    {
        public static void Main(string[]args)
        {
            //Console.WriteLine("Hello world");

            Console.WriteLine("All Employees:\n");
            var emps = Employees.GetEmployees().ToList();
            emps.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\n");


            // Skip methods
            /*
            Console.WriteLine("\n\nSkip First 10 Employees:\n");
            SkipFirstXEmployees(10);
            Console.WriteLine("\n\n");


            Console.WriteLine("\n\nSkip Last 10 Employees:\n");
            SkipLastXEmployees(10);
            Console.WriteLine("\n\n");


            Console.WriteLine("\n\nSkip Employees salary 4000:\n");
            SkipEmployeesUntilSalary4000();
            Console.WriteLine("\n\n");
            */


            // Take methods:
            /*
            Console.WriteLine("\n\nSkip First 10 Employees:\n");
            TakeFirstXEmployees(10);
            Console.WriteLine("\n\n");


            Console.WriteLine("\n\nSkip Last 10 Employees:\n");
            TakeLastXEmployees(10);
            Console.WriteLine("\n\n");


            Console.WriteLine("\n\nSkip Employees salary 4000:\n");
            TakeEmployeesUntilSalary4000();
            Console.WriteLine("\n\n");
            */




            // Pagination:
            /* 
            var FirstPage = emps.Paginate();
            FirstPage.Result.ToList().Print($"page: {FirstPage.Page} record per page: {FirstPage.RecordPerPage}:");
          




            var SecondPage = emps.Paginate(2);
            SecondPage.Result.ToList().Print($"page: {SecondPage.Page} record per page: {SecondPage.RecordPerPage}:");




            var ThirdPage = emps.Paginate(3);
            ThirdPage.Result.ToList().Print($"page: {ThirdPage.Page} record per page: {ThirdPage.RecordPerPage}:");




            var FourthPage = emps.Paginate(4);
            FourthPage.Result.ToList().Print($"page: {FourthPage.Page} record per page: {FourthPage.RecordPerPage}:");



            var FifthPage = emps.Paginate(5);
            FifthPage.Result.ToList().Print($"page: {FifthPage.Page} record per page: {FifthPage.RecordPerPage}:");
            */
        }



        public static void SkipEmployeesUntilSalary4000()
        {
            var emps = Employees.GetEmployees();

            var SkipEmployeesUntilSalary4000 = emps.OrderBy(e=>e.Salary).SkipWhile(e => e.Salary != 4000).ToList();

            SkipEmployeesUntilSalary4000.ForEach(e => Console.WriteLine(e));
        }
        public static void SkipFirstXEmployees(int NumberOfEmployeesForSkip)
        {
            var emps = Employees.GetEmployees();

            var SkipFirstXEmployees = emps.Skip(NumberOfEmployeesForSkip).ToList();

            SkipFirstXEmployees.ForEach(e => Console.WriteLine(e));
        }
        public static void SkipLastXEmployees(int NumberOfEmployeesForSkip)
        {
            var emps = Employees.GetEmployees();

            var SkipLastXEmployees = emps.SkipLast(NumberOfEmployeesForSkip).ToList() ;

            SkipLastXEmployees.ForEach(e => Console.WriteLine(e));
        }


        public static void TakeFirstXEmployees(int NumberOfEmployeesToTake)
        {
            var emps = Employees.GetEmployees();

            var TakeFirstXEmployees = emps.Take(NumberOfEmployeesToTake).ToList();

            TakeFirstXEmployees.ForEach(e => Console.WriteLine(e));
        }
        public static void TakeLastXEmployees(int NumberOfEmpoyeesToTake)
        {
            var emps = Employees.GetEmployees();

            var TakeLastXEmployees = emps.TakeLast(NumberOfEmpoyeesToTake).ToList();

            TakeLastXEmployees.ForEach(e => Console.WriteLine(e));
        }
        public static void TakeEmployeesUntilSalary4000()
        {
            var emps = Employees.GetEmployees();

            var TakeEmployeesUntilSalary4000 = emps.OrderBy(e => e.Salary).TakeWhile(e => e.Salary != 4_000).ToList();

            TakeEmployeesUntilSalary4000.ForEach(e => Console.WriteLine(e));
        }

       

    }


    // For pagination and print extension methods
    public static class Extension
    {
        public static (IEnumerable<T> Result,int Page,int RecordPerPage) Paginate<T>(this IEnumerable<T>source, int PageNumber=1,int RecordPerPage=10) where T : class 
        {
            int Page = 0;
            int RPerPage = 0;


            int Pages = (int)Math.Ceiling((decimal)source.Count() / RecordPerPage);

            if (PageNumber <= 0 || Pages < PageNumber)
                PageNumber = 1;


            if (RecordPerPage <= 0)
                RecordPerPage = 10;

            Page = PageNumber;
            RPerPage = RecordPerPage;

            var Result = source.Skip((PageNumber - 1) * RecordPerPage).Take(RecordPerPage);

            return (Result,Page,RPerPage);

        }

        public static void Print (this List<Employee> emps,string message)
        {
            Console.WriteLine("\n\n"+message);
            emps.ForEach( e => Console.WriteLine(e));
            Console.WriteLine("\n\n");
        }
    }
}
