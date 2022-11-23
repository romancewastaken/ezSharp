using System;
using System.Net;

namespace ezSharp
{
    internal class net
    {
        /// <param name="link">Direct link to download</param>
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

        /// <param name="link">Link  to page to scrape</param>
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
