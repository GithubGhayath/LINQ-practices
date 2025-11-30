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

        public static IEnumerable<TSource> Paginate1<TSource>(this IEnumerable<TSource> source,int PageNumber = 1,int RecordPerPage = 10)
        {

            if (source == null) throw new ArgumentNullException(nameof(source));
            if (PageNumber <= 0) throw new ArgumentOutOfRangeException(nameof(PageNumber));
            if (RecordPerPage <= 0) throw new ArgumentOutOfRangeException(nameof(RecordPerPage));



            return source.Skip((PageNumber - 1) * RecordPerPage).Take(RecordPerPage);
        }
        public static IEnumerable<Tsource> WhereWithPaginate<Tsource>(this IEnumerable<Tsource> source,Func<Tsource,bool>Predicate, int PageNumber = 1, int RecordPerPage = 10)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (PageNumber <= 0) throw new ArgumentOutOfRangeException(nameof(PageNumber));
            if (RecordPerPage <= 0) throw new ArgumentOutOfRangeException(nameof(RecordPerPage));

            var Result = Enumerable.Where(source, Predicate);

            return Result.Skip((PageNumber - 1) * RecordPerPage).Take(RecordPerPage);
        }
    }
}
