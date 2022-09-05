using System;
using System.Diagnostics;
using System.IO;

namespace ezSharp
{
    public class fstream
    {
        private static bool folderExists(string path)
        {
            try
            {
                bool exists = Directory.Exists(path);

                if (exists)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool fileExists(string path)
        {
            try
            {
                bool exists = File.Exists(path);

                if (exists)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void openFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    Process.Start(path);
                }
                
                else
                {
                    Console.Write("File doesn't exist");
                }
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public static void renameFile(string currentName, string newName)
        {
            try
            {
                if (fileExists(currentName))
                {
                    File.Move(currentName, newName);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public static void writeFile(string path, string content)
        {
            if (!fileExists(path))
            {
                File.WriteAllText(path, content);
            }
        }
    }
}
