using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            string result=test.StringCompare("1","2","3");
            Console.WriteLine(result);
        }
    }
}
