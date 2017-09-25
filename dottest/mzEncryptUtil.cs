using System;
using System.Runtime.InteropServices;

namespace MapZone.Core
{
    /// <summary>
    /// 加密解密处理类
    /// </summary>
    public class mzEncryptUtil
    {
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
    }
}
