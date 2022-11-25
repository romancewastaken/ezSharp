using Memory;

namespace ezSharp
{
    public class memoryEditor
    {
        public static Mem Memory = new Mem();

        /// <param name="process">Name of process</param>
        public static void openProcess(string process)
        {
            Memory.OpenProcess(process);
        }

        /// <param name="path">Location to save dump file</param>
        public static void dumpMemory(string path)
        {
            Memory.DumpMemory(path + @"\mem.dmp");
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static void writeMemory(string pointer, string type, string value)
        {
            Memory.WriteMemory("base+" + pointer, type, value);
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static void freezeValue(string pointer, string type)
        {
            Memory.FreezeValue("base+" + pointer, type, "10");
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static void unfreezeValue(string pointer)
        {
            Memory.UnfreezeValue("base+" + pointer);
        }


        // read functions // 

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static string readString(string pointer)
        {
            return Memory.ReadString("base+" + pointer);
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static int readInt(string pointer)
        {
            return Memory.ReadInt("base+" + pointer);
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static float readFloat(string pointer)
        {
            return Memory.ReadFloat("base+" + pointer);
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static double readDouble(string pointer)
        {
            return Memory.ReadDouble("base+" + pointer);
        }

        /// <param name="pointer">Add your offsets by doing ,{offset} after your pointer</param>
        public static byte readByte(string pointer)
        {
            return (byte)Memory.ReadByte("base+" + pointer);
        }
    }
}
