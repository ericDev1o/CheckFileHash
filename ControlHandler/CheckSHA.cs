using System;
using System.IO;
using System.Security.Cryptography;
namespace WPF_hashCheck.ControlHandler;

public class CheckSHA
{
    /*
    <summary>
        This method compares the computed hash of the downloaded file with the expected one.
        It displays OK if they match.
    </summary>
    <param name="path">
        absolute path of the file
    </param>
    <param name="expectedHash">
        SHA512 or default lower expected hash
    </param>
    <returns>
        The check result is either OK or an error due to hash mismatch.
        The tuple returned is the computed hash and the result message.
    </returns>
    */
    public static ValueTuple<string, string> Check(string path, string expectedHash)
    {
        HashAlgorithm sHA512 = SHA512.Create();
        using(FileStream fs = new FileStream(@"C:\softwareDownloads\dotnet-sdk-7.0.202-win-x64.exe",FileMode.Open))
        {
            byte[] hashComputed = sHA512.ComputeHash(fs);
            string hashComputedString = BitConverter.ToString(hashComputed).ToLower().Replace("-","");
            string hashExpectedString = "58e9437f2ead1e9edd67d837f7d2e1313d866d510629465b0485965a9540c65eddd6fffafad9cf3261cb476a1dfff20404908f3bf06a7e01bc3bebc0bcb27d39";
            ValueTuple<string, string> checkResult =("", "");
            if(hashComputedString==hashExpectedString)
                checkResult = 
                (
                    hashComputedString, 
                    String.Format("Hash checked OK: computed = {0}, expected = {1}", hashComputedString, hashExpectedString)
                );
            else
                checkResult = 
                (
                    hashComputedString, 
                    String.Format("Hash check error: computed = {0}, expected = {1}", hashComputedString, hashExpectedString)
                );
            return checkResult;
        }         
    }
}