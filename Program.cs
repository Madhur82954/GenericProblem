using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            int result=test.IntCompare(3,2,1);
            Console.WriteLine(result);
        }
    }
}
