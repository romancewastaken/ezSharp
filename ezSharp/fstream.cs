using System;
using System.Diagnostics;
using System.IO;

namespace ezSharp
{
    public class fstream
    {
        /// <param name="path">Path to folder/param>
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

        /// <param name="path">Path to file</param>
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

        /// <param name="path">Path to file</param>
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

        /// <param name="currentName">Current path</param>
        /// <param name="newName">New path</param>
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

        /// <param name="path">Path to file</param>
        /// <param name="name">Name of file</param>
        ///<param name="type">Type of file extension</param>
        /// <param name="content">Content of new file</param>
        public static void writeFile(string path, string name, string type, string content)
        {
            if (!fileExists(path))
            {
                File.WriteAllText(path + "/" + name + "." + type, content);
            }
        }
    }
}
