using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace MD5HashCreater
{
    class MD5Hash
    {
        internal static string Compute(FileStream streem)
        {
            byte[] byteArr = new byte[streem.Length];
            //List<byte> byteList = new List<byte>();
            string HashStr = "";
            /*int i = 0;
            foreach (char temp in str.ToCharArray())
            {
                byteList.Add((byte)temp);
                i++;
            }
            i = 0;*/
            streem.Read(byteArr, 0, (int)streem.Length);
            //byteArr = byteList.ToArray();
            var md5Hash = MD5Cng.Create().ComputeHash(byteArr);
            HashStr = BitConverter.ToString(md5Hash).Replace("-", String.Empty).ToLower();
            return HashStr;
        }
    }
}
