using System;
using System.Net;

namespace ezSharp
{
    public class net
    {
        public static WebClient client = new WebClient();

        /// <param name="link">Direct link to download</param>
        //  <param name="fileName">Name to save the file as</param>
        /// <param name="extensionType">Type of file</param>
        public static void downloadFile(string link, string path, string fileName, string extensionType)
        {
            try
            {
                client.DownloadFileAsync(new Uri(link), path + $"/{fileName}.{extensionType}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <param name="link">Link  to page to scrape</param>
        public static string readString(string link)
        {
            try
            {
                return client.DownloadString(link);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
