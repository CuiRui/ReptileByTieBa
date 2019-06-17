#region Header
// ——————————————————————————————————————–

//  ┏┓　　　┏┓

// ┏┛┻━━━┛┻┓

// ┃　　　　　　　┃ 　

// ┃　　　━　　　┃

// ┃　┳┛　┗┳　┃

// ┃　　　　　　　┃

// ┃　　　┻　　　┃

// ┃　　　　　　　┃

// ┗━┓　　　┏━┛

//     ┃　　　┃   神兽保佑　　　　　　　　　

//     ┃　　　┃   代码无BUG！

//     ┃　　　┗━━━┓

//     ┃　　　　　　　┣┓

//     ┃　　　　　　　┏┛

//     ┗┓┓┏━┳┓┏┛

//       ┃┫┫　┃┫┫

//       ┗┻┛　┗┻┛

// ——————————————————————————————————————–
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReptileByTieBa.ClassLibrary
{
    public class HttpRequest
    {
        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="url">要请求的URL</param>
        /// <param name="Timeout">超时时间</param>
        /// <returns></returns>
        public static string GetHttpResponse(string url, int Timeout)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = Timeout;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

    }
}
