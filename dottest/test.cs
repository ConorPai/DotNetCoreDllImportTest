using System;
using System.Runtime.InteropServices;

namespace test
{
    public class testClass
    {
        public testClass()
        {

        }

        [DllImport("libc.dylib", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern int Add(int a, int b);

        public int TestAdd(int a, int b)
        {
            int nResult = Add(a, b);
            Console.WriteLine(nResult);
            return nResult;
        }
    }
}