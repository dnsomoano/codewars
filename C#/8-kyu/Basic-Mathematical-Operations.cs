// Your task is to create a function that does four basic mathematical operations.

// The function should take three arguments - operation(string/char), value1(number), value2(number).
// The function should return result of numbers after applying the chosen operation.

// Examples:

// basicOp('+', 4, 7)         // Output: 11
// basicOp('-', 15, 18)       // Output: -3
// basicOp('*', 5, 5)         // Output: 25
// basicOp('/', 49, 7)        // Output: 7
using NUnit.Framework;
using System;

namespace Solution
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            if (operation == '+')
                return value1 + value2;
            else if (operation == '-')
                return value1 - value2;
            else if (operation == '*')
                return value1 * value2;
            else
                return value1 / value2;
        }
    }
}

// BEST PRACTICES
// #1 Switch case
namespace Solution
{
    public static class Program
    {
        public static double basicOp(char op, double val1, double val2)
        {
            switch (op)
            {
                case '+': return val1 + val2;
                case '-': return val1 - val2;
                case '*': return val1 * val2;
                case '/': return val1 / val2;
                default:
                    throw new System.ArgumentException("Unknown operation!", op.ToString());
            }
        }
    }
}

// #2 Dictionary
namespace Solution
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        public static double basicOp(char op, double val1, double val2)
        {
            return new Dictionary<char, Func<double, double, double>>()
      {
          { '+', (a, b) => a + b },
          { '-', (a, b) => a - b },
          { '*', (a, b) => a * b },
          { '/', (a, b) => a / b }
      }[op](val1, val2);
        }
    }
}

// #3 Ternary Operator
namespace Solution
{
    public static class Program
    {
        public static double basicOp(char op, double val1, double val2)
        {
            return op == '+' ? val1 + val2
                : op == '-' ? val1 - val2
                : op == '*' ? val1 * val2
                : val1 / val2;
        }
    }
}

namespace Solution
{

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(Program.basicOp('+', 4, 7), 11);
            Assert.AreEqual(Program.basicOp('-', 15, 18), -3);
            Assert.AreEqual(Program.basicOp('*', 5, 5), 25);
            Assert.AreEqual(Program.basicOp('/', 49, 7), 7);
        }
    }
}