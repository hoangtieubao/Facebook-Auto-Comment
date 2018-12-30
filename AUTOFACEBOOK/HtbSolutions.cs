using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;

public class HtbSolutions
{
    public async static Task<string> HttpRequest(string URL)
    {
        HttpWebRequest request = WebRequest.CreateHttp(URL);
        WebResponse response = await request.GetResponseAsync();
        StreamReader source = new StreamReader(response.GetResponseStream());
        return source.ReadToEnd();
    }

    public static string CreateMD5(string data)
    {
        byte[] hash = (MD5.Create()).ComputeHash(Encoding.ASCII.GetBytes(data));
        StringBuilder retstr = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            retstr.Append(hash[i].ToString("x2"));
        }
        return retstr.ToString();
    }
}
