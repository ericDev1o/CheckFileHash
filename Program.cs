using System;
using System.IO;
using System.Security.Cryptography;

namespace CheckFileHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = new string(@"C:\Installers\dotnet-sdk-6.0.402-win-x64.exe");
            string hash = "6cf89974261e6a12cbd5531bc2b16231daf56e438325750b381dacfd5d09c80a9addf739c1a3e28f652a7adf13971e37acaf255cd8c61ac39e903ff8ba2655c0";
            if(File.Exists(path))
            {
                HashAlgorithm shaM = SHA512.Create();
                using(FileStream fs = File.Open(path,FileMode.Open,FileAccess.Read,FileShare.ReadWrite))
                {
                    try
                    {
                        byte[] computeHash = shaM.ComputeHash(fs);
                        string computeHashString = BitConverter.ToString(computeHash).Replace("-", "");
                        string expected = hash.ToUpper();
                        if (computeHashString == expected)
                            Console.WriteLine(string.Format("Hash checked OK : {0}", expected));
                        else 
                            Console.WriteLine(string.Format("Hash checked KO : expected : {0}, computed : {1}", expected, computeHashString));
                    }catch(IOException e)
                    {
                        Console.WriteLine(string.Format("IO error: message= {0}, stacktrace= {1}",e.Message,e.StackTrace));
                        fs.Close();
                    }
                }
            }
            else{
                Console.WriteLine("The path you typed is not valid");
            }
        }
    }
}