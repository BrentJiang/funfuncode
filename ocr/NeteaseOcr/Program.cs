using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace NeteaseOcr
{
    /// <summary>
    /// 支持System.Drawing:
    /// Install-Package System.Drawing-dotnet-core
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            string url = "http://openapi.youdao.com/ocrapi";
            string img = ImgToBase64String(@"E:\qcenglish\image2.jpg");
            var appKey = "17e7c85fedec9a1d";
            string salt = DateTime.Now.Millisecond.ToString();
            var appSecret = "NzDAf5XY9PfznJrXme2GSbdifiCpp3es";
            var md5Str = $"{appKey}{img}{salt}{appSecret}";
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(md5Str));

            string sign = BitConverter.ToString(output).Replace("-", "");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string langType = "en";
            String imageType = "1";
            string detectType = "10012";
            dic.Add("img", System.Web.HttpUtility.UrlEncode(img));
            dic.Add("appKey", appKey);
            dic.Add("langType", langType);
            dic.Add("detectType", detectType);
            dic.Add("imageType", imageType);
            dic.Add("salt", salt);
            dic.Add("sign", sign);
            s.Stop();
            string result = Post(url, dic);
            Console.WriteLine(result);
            Console.WriteLine($"Total cost: {s.ElapsedTicks} ticks.");
        }

        protected static string ImgToBase64String(string Imagefilename)
        {

            byte[] bytes = File.ReadAllBytes(Imagefilename);
            string img = Convert.ToBase64String(bytes);
            return img;
        }

        public static string Post(string url, Dictionary<string,string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            Console.WriteLine(builder.ToString());
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
