using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            string result=test.StringCompare("3","2","1");
            Console.WriteLine(result);
        }
    }
}
