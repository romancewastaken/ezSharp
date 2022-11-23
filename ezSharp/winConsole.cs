using System;
using System.Runtime.InteropServices;

namespace ezSharp
{
    internal class winConsole
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]


        public static extern bool AllocConsole();    //allocate console

        /// <param name="title">Title of console</param>
        /// /// <param name="message">Output of console</param>
        public static void Update(string title, string message)
        {
            try
            {
                Console.Title = title;
                Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
