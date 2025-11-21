using Repository.Entities;
using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenationStatement
{
    internal class ConcatenationStatementProgram
    {

        public static void Main(string[] args)
        {
            RunExample04();
        }

        public static void RunExample01()
        {
            var EmployeesPart1 = Employees.GetRange(0, 5);

            var EmployeesPart2 = Employees.GetRange(5, 10);


            Console.WriteLine("This is first part");
            EmployeesPart1.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\nThis is Second part");
            EmployeesPart2.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\n\n After Concatenation:");

            EmployeesPart1.Concat(EmployeesPart2).ToList().ForEach(e => Console.WriteLine(e));
        }
        public static void RunExample02()
        {
            int Counter = 0;
            var EmployeesNamePart1 = Employees.GetRange(0, 5).Select(e => 
                {
                    Counter++;
                    var emp = new EmpsNameDto 
                    {
                        Count = Counter,
                        Name = e.Name
                    };
                    return emp;
                }).ToList();

            var EmployeesNamePart2 = Employees.GetRange(5,10).Select(e => {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;
            }).ToList();


            Console.WriteLine("Employees Name Part 1:");
            EmployeesNamePart1.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\nEmployees Name Part 2:");
            EmployeesNamePart2.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\n\n Employees Names concatenation:");
            EmployeesNamePart1.Concat(EmployeesNamePart2).ToList().ForEach(e=>Console.WriteLine(e));
        }
        public static void RunExample03()
        {
            int Counter = 0;
            var EmployeesPart1 = Employees.GetRange(0,5);
            var EmployeesPart2 = Employees.GetRange(5,10);



            Console.WriteLine("Employees Part 1:");
            EmployeesPart1.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\nEmployees Part 2:");
            EmployeesPart2.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\n\nEmployees Concatenation:");
             EmployeesPart1.Select(e => 
            {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;
            }).Concat(EmployeesPart2.Select(e => 
            {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;
            })).ToList().ForEach(e=>Console.WriteLine(e));
           

        }
        public static void RunExample04()
        {
            int Counter = 0;
            var EmployeesPart1 = Employees.GetRange(0, 5);
            var EmployeesPart2 = Employees.GetRange(5, 10);

            var EmployeesConcatenation = new[] { EmployeesPart1.Select(e =>
            {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;

            }), EmployeesPart2.Select(e=>
            {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;
            }) }.SelectMany(e=>e);


            Counter = 0;

            Console.WriteLine("Employees Part 1:");
            EmployeesPart1.Select(e => 
            {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;
            }).ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\nEmployees Part 2:");
            EmployeesPart2.Select(e => 
            {
                Counter++;
                var emp = new EmpsNameDto
                {
                    Count = Counter,
                    Name = e.Name
                };
                return emp;
                
            }).ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n\n\nEmployees Concatenation:");
            foreach(var item in EmployeesConcatenation)
                Console.WriteLine(item);    

        }
    }
    public class EmpsNameDto
    {
        public int Count { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"[{this.Count}] - {this.Name}";
        }
    }

}
