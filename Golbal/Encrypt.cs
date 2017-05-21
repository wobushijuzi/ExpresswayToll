using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Golbal
{
    public class Encrypt
    {
        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="Express">明文密码</param>
        /// <returns></returns>
        public static byte[] Encryption(string Express)
        {
            byte[] result = Encoding.Default.GetBytes(Express);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return output;
        }
    }
}