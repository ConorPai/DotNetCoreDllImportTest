using System;
using System.Runtime.InteropServices;

namespace test
{
    public class testClass
    {
        public testClass()
        {

        }

        //dylib是MacOS下的动态链接库扩展名，Linux下是so，Windows下是dll
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
