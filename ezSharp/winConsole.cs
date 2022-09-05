using System;
using System.Runtime.InteropServices;

namespace ezSharp
{
    internal class winConsole
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]


        public static extern bool AllocConsole();    //allocate console

        //use this function when your application starts + when you want to update the console
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
