using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementOperations
{
    internal class ElementOperationsProgram
    {
        public static void Main(string[] args)
        {
            var Emps = Employees.GetEmployees();


            // ElementAt(Index)
            /*
            // This gives the third employee in last (Zero based index)
            var ThirdEmployee = Emps.ElementAt(3);

            // This gives System.ArgumentOutOfRange Exception   This solve in ======> ElementAtOrDefault(Index)
            //var ThirdEmployee = Emps.ElementAt(1651);

            Console.WriteLine(ThirdEmployee.ToString());
            */



            // ElementAtOrDefault(index)
            /*
            // This don't give a System.ArgumentOutOfRange Exception it just store (Null)
            var OutOfRangeElement = Emps.ElementAtOrDefault(1651);

            if (OutOfRangeElement is null)
            {
                Console.WriteLine("The employee not found!");
            }
            else
            {
                 Console.WriteLine(OutOfRangeElement.ToString());
            }
            */




            // First(exp)
            /*
            // This gives the first item matches the condition
            //var FirstElementGet4000Salary = Emps.First(s => s.Salary == 4000);

            // This gives System.InvalidOperation Exception because there is no item that match the condition This solve in ======> FirstOrDefault(exp)
            var FirstElementGet4000000Salary = Emps.First(s => s.Salary == 4000000);

            Console.WriteLine(FirstElementGet4000000Salary.ToString());
            */





            // FirstOrDefault(exp)
            /*
             //  This don't give a System.InvalidOperation Exception it just store (Null)
            var FirstElementGet4000000Salary = Emps.FirstOrDefault(s => s.Salary == 4000);

            if(FirstElementGet4000000Salary is null)
            {
                Console.WriteLine("There is no employee matches the condition");
            }
            else
            {
                Console.WriteLine(FirstElementGet4000000Salary.ToString());
            }
            */




            // Last(exp)
            /*
            // This returns the last employee gets 4000 salary
            var LastEmployeeGet4000Salary = Emps.Last(e => e.Salary == 4000);

            // This gives System.InvalidOperation Exception because there is no item that match the condition This solve in ======> LastOrDefault(exp)
            var LastEmployeeGet400000000Salary = Emps.Last(e => e.Salary == 400000000);
            Console.WriteLine(LastEmployeeGet400000000Salary.ToString());
            */



            // LstOrDefault(exp)
            /*
            // This don't give a System.InvalidOperation Exception it just store (Null)
            var LastEmployeeGet400000000Salary = Emps.LastOrDefault(e => e.Salary == 400000000);

            if(LastEmployeeGet400000000Salary is null)
            {
                Console.WriteLine("There is no employee matches the condition");
            }
            else
            {
                Console.WriteLine(LastEmployeeGet400000000Salary.ToString());
            }
            */



            // Single(exp)
            /*
            // This returns the employee with ID = 2022-AA-1234 
            //var EmployeeWithID_2022_AA_1234 = Emps.Single(e => e.Id == "2022-AA-1234");


            // This returns System.InvalidOperation Exception because there is no employee with ID 2022-AA-11034
            var EmployeeWithID_2022_AA_11034 = Emps.Single(e => e.Id == "2022-AA-11034");

            Console.WriteLine(EmployeeWithID_2022_AA_11034);
            */


            // SingleOrDefault(exp)
            /*
            // This returns System.InvalidOperation Exception because there is no employee with ID 2022-AA-11034
            var EmployeeWithID_2022_AA_11034 = Emps.SingleOrDefault(e => e.Id == "2022-AA-11034");
            Console.WriteLine(EmployeeWithID_2022_AA_11034);
            */
        }
    }
}
