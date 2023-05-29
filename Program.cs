using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            float result=test.floatCompare(1.1f,2.1f,3.3f);
            Console.WriteLine(result);
        }
    }
}
