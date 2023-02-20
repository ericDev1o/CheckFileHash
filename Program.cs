using System.Security.Cryptography;
using System;
using System.IO;
namespace SHA512test
{
    class Program
    {
        static void Main(string[] args)
        {
            HashAlgorithm sHA512 = SHA512.Create();
            using(FileStream fs = new FileStream(@"C:\softwareDownloads\dotnet-sdk-7.0.200-win-x64.exe",FileMode.Open))
            {
                byte[] hashComputed = sHA512.ComputeHash(fs);
                string hashComputedString = BitConverter.ToString(hashComputed).ToLower().Replace("-","");
                string hashExpectedString = "e41ce0c55181b564b29b3e4bd9e76be294db57d2ec0f152a295bdbae37b422a46bdbcb1c680f2d56d098ac8298533658d3d4ff8c50f1716652ebd012e93da292";
                if(hashComputedString==hashExpectedString)
                    Console.WriteLine("Hash checked OK: computed "+hashComputedString+" = expected "+hashExpectedString);
                else
                    Console.WriteLine("Hash check error: computed = "+hashComputedString+", expected = "+hashExpectedString);
            }           
        }
    }
}