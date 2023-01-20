using System.IO;

namespace SRP
{
    public static class FileLogger
    {
        public static void ErrorLOgger(string error)
        {
            File.WriteAllText(@"c:\Error.txt", error);
        }
        public static void ErrorLOgger(string error, string message)
        {
            File.WriteAllText(@"c:\Error.txt", error + message);
        }
        public static void DatabaseLogger(string message)
        {
            System.Console.WriteLine("database logger");
            System.Console.WriteLine("test1");
        }
    }
}
