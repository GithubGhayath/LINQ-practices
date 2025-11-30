using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTrees
{
    internal class ExpressionTreesProgram
    {
        public static void Main(string[] args)
        {
            RunExample03();

        }

        private static void RunExample03()
        {
            // Num => Num % 2 == 0

            ParameterExpression NumParam = Expression.Parameter(typeof(int), "Num"); 
            ConstantExpression ZeroParam = Expression.Constant(0,typeof(int)); 
            ConstantExpression TwoParam = Expression.Constant(2,typeof(int));

            BinaryExpression ModuloBinaryExpression = Expression.Modulo(NumParam, TwoParam);

            BinaryExpression IsEvenBinaryExpression = Expression.Equal(ModuloBinaryExpression, ZeroParam);

            Expression<Func<int, bool>> IsEven = Expression.Lambda<Func<int, bool>>(IsEvenBinaryExpression, new ParameterExpression[] { NumParam });

            Console.WriteLine(IsEven.Compile()(7));
        }

        private static void RunExample02()
        {
            Expression<Func<int, bool>> IsNegativeExpression = num => num < 0;

            ParameterExpression param = IsNegativeExpression.Parameters[0];
            BinaryExpression Operation = (BinaryExpression)IsNegativeExpression.Body;
            ParameterExpression Left = (ParameterExpression)Operation.Left;
            ConstantExpression Right = (ConstantExpression)Operation.Right;

            Console.WriteLine($"Decomposed Expression: {param.Name} => {Left.Name} {Operation.NodeType} {Right.Value}");
        }

        private static void RunExample01()
        {
            Expression<Func<int, bool>> IsEvenExpression = num => num % 2 == 0;

            Console.WriteLine(IsEvenExpression); // This will print expression:  num => ((num % 2) == 0)

            var IsEven = IsEvenExpression.Compile();

            Console.WriteLine(IsEven(10));  // This will perform the expression: 10 => ((10 % 2) == 0) and returns (true - false)
        }
    }
}
