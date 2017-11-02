using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MapZone.Core
{
    /// <summary>
    /// 加密解密处理类
    /// </summary>
    public class mzEncryptUtil
    {
        //dylib是MacOS下的动态链接库扩展名，Linux下是so，Windows下是dll
        [DllImport("libc.dylib", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern void mzEncryptUtil_encrypt_default(byte[] src, int nLength);
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="src">加密源</param>
        /// <returns>加密结果</returns>
        static public byte[] encrypt(byte[] src)
        {
            mzEncryptUtil_encrypt_default(src, src.Length);
            return src;
        }

        //dylib是MacOS下的动态链接库扩展名，Linux下是so，Windows下是dll
        [DllImport("libc.dylib", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern void mzEncryptUtil_encrypt(byte[] src, int nLength, int secretcode);
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="src">加密源</param>
        /// <param name="secretcode">加密码</param>
        /// <returns>加密结果</returns>
        static public byte[] encrypt(byte[] src, int secretcode)
        {
            mzEncryptUtil_encrypt(src, src.Length, secretcode);
            return src;
        }

        //dylib是MacOS下的动态链接库扩展名，Linux下是so，Windows下是dll
        [DllImport("libc.dylib", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern void mzEncryptUtil_decrypt_default(byte[] src, int nLength);
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="src">解密源</param>
        /// <returns>解密结果</returns>
        static public byte[] decrypt(byte[] src)
        {
            mzEncryptUtil_decrypt_default(src, src.Length);
            return src;
        }

        //dylib是MacOS下的动态链接库扩展名，Linux下是so，Windows下是dll
        [DllImport("libc.dylib", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern void mzEncryptUtil_decrypt(byte[] src, int nLength, int secretcode);
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="src">解密源</param>
        /// <param name="secretcode">解密码</param>
        /// <returns>解密结果</returns>
        static public byte[] decrypt(byte[] src, int secretcode)
        {
            mzEncryptUtil_decrypt(src, src.Length, secretcode);
            return src;
        }

        /// <summary>
        /// 生成随机密码表
        /// </summary>
        static public string createkey()
        {
            StringBuilder str = new StringBuilder();

            //添加小写字母
            for (int i = 0; i < 26; i++)
            {
                str.Append((char)(97 + i));
            }
            //添加大写字母
            for (int i = 0; i < 26; i++)
            {
                str.Append((char)(65 + i));
            }
            //添加数字
            for (int i = 0; i < 10; i++)
            {
                str.Append((char)(48 + i));
            }

            StringBuilder sbResult = new StringBuilder();

            Random rd = new Random();
            char[] seed = str.ToString().ToCharArray();
            char clast = seed[0];
            for (int i = 0; i < 1024; i++)
            {
                //随机获取
                char cnew = seed[rd.Next(62)];

                //保证和上一个不一致
                while (cnew == clast)
                {
                    cnew = seed[rd.Next(62)];
                }
                sbResult.Append(cnew);
                clast = cnew;
            }

            return sbResult.ToString();
        }
    }
}
