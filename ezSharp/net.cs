using System;
using System.Net;

namespace ezSharp
{
    internal class net
    {
        public static void downloadFile(string link, string path)
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri(link), path);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public static string readString(string link)
        {
            try
            {
                WebClient client = new WebClient();
                return client.DownloadString(link);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
