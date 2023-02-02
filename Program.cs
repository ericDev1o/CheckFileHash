using System;
using System.IO;
using System.Security.Cryptography;
namespace CheckFileHash;
class Program
{
    static void Main(string[] args)
    {
        //HashAlgorithm sHA512 = SHA512.Create();
        HashAlgorithm sHA256 = SHA256.Create();
        using(FileStream fs = new FileStream(@"C:\softwareDownloads\npp.8.4.9.Installer.x64.exe",FileMode.Open))
        {
            //byte[] hashComputed = sHA512.ComputeHash(fs);
            byte[] hashComputed = sHA256.ComputeHash(fs);
            string hashComputedString = BitConverter.ToString(hashComputed).ToLower().Replace("-","");
            string hashExpectedString = "6b170127061feb082ffd1b14309ef6d4a783df3c0fd51999e1786067731a49f3";
            if(hashComputedString==hashExpectedString)
                Console.WriteLine("Hash checked OK: computed "+hashComputedString+" = expected "+hashExpectedString);
            else
                Console.WriteLine("Hash check error: computed = "+hashComputedString+", expected = "+hashExpectedString);
        }           
    }
}