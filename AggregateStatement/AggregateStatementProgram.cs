using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateStatement
{
    internal class AggregateStatementProgram
    {
        public static void Main(string[]args)
        {
           
        }

        public static void RunExample01()
        {
            
            List<int >Numbers = new List<int>();
            Numbers = new List<int> { 1, 2, 3, 4, 5 };

            int SumOfNumbers = Numbers.Aggregate(5, (a, b) => a += b);

            Console.WriteLine(SumOfNumbers);
        }

        public static void RunExample02()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            var Words = new List<string> { "Hello", "I'm", "Ghayath", "Alali" };

            var ConcatonationOfWords = Words.Aggregate((acc, next) => acc += $" {next}");


            var Average = numbers.Aggregate((a, b) => a += b);

            Console.WriteLine(ConcatonationOfWords);
        }

      
    }
}
