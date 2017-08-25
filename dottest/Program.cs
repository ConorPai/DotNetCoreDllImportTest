using System;
using test;

namespace dottest
{
    class Program
    {
        static void Main(string[] args)
        {
            testClass test = new testClass();
            Console.WriteLine(test.TestAdd(5, 7));
        }
    }
}
