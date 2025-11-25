using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Extensions
{
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> source,string Title)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{Title}\n");
            Console.ForegroundColor = defaultColor;
            source.ToList().ForEach(item => Console.WriteLine(item));
        }
    }
}
