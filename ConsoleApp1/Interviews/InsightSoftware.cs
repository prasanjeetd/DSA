using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class InsightSoftware
    {
        public int Calculator(int a, int b, string operation)
        {
            if (operation == "sum")
            {
                return a + b;
            }
            else if (operation == "subtract")
            {
                return a - b;
            }
            else if (operation == "multiply")
            {
                return a * b;
            }
            return 0;
        }
    }

    public interface IOperation
    {
        int Calculate(int a, int b);
    }

    public class Sum : IOperation
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }

    public class Subract : IOperation
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }

    public class Calculator
    {
        private readonly List<IOperation> _operations;

        public Calculator(List<IOperation> operations)
        {
            _operations = operations ?? throw new ArgumentNullException(nameof(operations));
        }

        public int Calculate(int a, int b, string operation)
        {
            var output = OperationFactory.Get(operation);

            return output.Calculate(a, b);
        }


    }

    public static class OperationFactory
    {
        public static IOperation Get(string operation)
        {
            var dic = new Dictionary<string, IOperation>
           {
               { "sum", new Sum() },
               { "subtract", new Subract() },
                { "multiply", new Multiply() }
           };

            return dic[operation];
        }
    }

    internal class Multiply : IOperation
    {
        public int Calculate(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
