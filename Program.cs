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
            using(FileStream fs = new FileStream(@"C:\softwareDownloads\dotnet-sdk-7.0.202-win-x64.exe",FileMode.Open))
            {
                byte[] hashComputed = sHA512.ComputeHash(fs);
                string hashComputedString = BitConverter.ToString(hashComputed).ToLower().Replace("-","");
                string hashExpectedString = "58e9437f2ead1e9edd67d837f7d2e1313d866d510629465b0485965a9540c65eddd6fffafad9cf3261cb476a1dfff20404908f3bf06a7e01bc3bebc0bcb27d39";
                if(hashComputedString==hashExpectedString)
                    Console.WriteLine("Hash checked OK: computed "+hashComputedString+" = expected "+hashExpectedString);
                else
                    Console.WriteLine("Hash check error: computed = "+hashComputedString+", expected = "+hashExpectedString);
            }           
        }
    }
}