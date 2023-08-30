using System;
using System.IO;

namespace ConsoleLoggers
{
    //Extension Methods
    public static class MyCompanyLogger
    {
        public static void SaveToLog(this string msg)
        {
            DateTime today = DateTime.Now;
            var path = Path.Combine(today.ToString("yyyy"), today.ToString("yyyyMM"));
            Directory.CreateDirectory(path);
            var filePath = Path.Combine(path, today.ToString("yyyyMMdd") + ".log");
            File.AppendAllText(filePath, $"{today}: {msg}{Environment.NewLine}");
        }

        public static void SaveToLog(this Exception ex) { }

        public static void Update(this Person person) { }
    }
}