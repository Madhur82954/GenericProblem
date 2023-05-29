using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            int result=test.Compareall<int>(2,1,3);
            Console.WriteLine(result);
        }
    }
}
