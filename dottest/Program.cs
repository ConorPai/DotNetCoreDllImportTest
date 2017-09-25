using System;
using System.IO;
using MapZone.Core;
using test;

namespace dottest
{
    class Program
    {
        static void Main(string[] args)
        {
            testClass test = new testClass();
            Console.WriteLine(test.TestAdd(5, 7));

            //加密传输
            MemoryStream ms = new MemoryStream(56);
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write(1.123456);
            bw.Write(2.123456);
            bw.Write(3.123456);
            bw.Write(4.123456);
            bw.Write(5.123456);
            bw.Write(6.123456);
            bw.Write(7.123456);

            byte[] enresult = mzEncryptUtil.encrypt(ms.ToArray(), 11);
            string strEncrypt = Convert.ToBase64String(enresult);

            //扫码解密
            byte[] deSrc = Convert.FromBase64String(strEncrypt);
            byte[] deresult = mzEncryptUtil.decrypt(deSrc, 11);

            MemoryStream msResult = new MemoryStream(deresult);
            BinaryReader br = new BinaryReader(msResult);

            Console.WriteLine(br.ReadDouble().ToString());
            Console.WriteLine(br.ReadDouble().ToString());
            Console.WriteLine(br.ReadDouble().ToString());
            Console.WriteLine(br.ReadDouble().ToString());
            Console.WriteLine(br.ReadDouble().ToString());
            Console.WriteLine(br.ReadDouble().ToString());
            Console.WriteLine(br.ReadDouble().ToString());
        }
    }
}
