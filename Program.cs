using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            float result=test.floatCompare(3.1f,1.1f,2.3f);
            Console.WriteLine(result);
        }
    }
}
