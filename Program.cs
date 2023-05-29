using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass<string> test = new TestClass<string>("3","4","2");
            string result=test.Compare("3", "4", "2");
            Console.WriteLine(result);
        }
    }
}
