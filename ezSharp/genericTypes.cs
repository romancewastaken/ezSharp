using System;
using System.Collections.Generic;

namespace ezSharp
{
    public class genericTypes
    {
        public static string[] stringArr = { "test", "test2" };
        int[] intArr;
        float[] floatArr;
        double[] doubleArr;




        /// <param name="array">Name of array</param>
        public static void appendToArr<T>(T[] array)
        {

        }

        /// <param name="array">Name of array</param>
        public static List<T> returnArr<T>(T[] array)
        {
            List<T> temp = new List<T>();

            foreach (T item in array)
            {
                temp.Add(item);
            }

            return temp;
        }
    }
}