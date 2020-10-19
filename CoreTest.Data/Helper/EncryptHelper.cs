using NETCore.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace CoreTest.Data.Helper
{
    public class EncryptHelper
    {
        private const string key = "DHDMTbKu7bi1bAEKYaVmVqJPj9NyuqqH";
        private const string iv = "DHDMTbKu7bi1bAEK";

        public static string AesEncryp(string source)
        {
            var encrypted = EncryptProvider.AESEncrypt(source, key, iv);
            return encrypted;
        }

        public static string AesDecrypt(string source)
        {
            var decrypted = EncryptProvider.AESDecrypt(source, key, iv);
            return decrypted;
        }

        public static string MD5(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return EncryptProvider.Md5(str);
            }
            else
            {
                return str;
            }
        }
    }
}
