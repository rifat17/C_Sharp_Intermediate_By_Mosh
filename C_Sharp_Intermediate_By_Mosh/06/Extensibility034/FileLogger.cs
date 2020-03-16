using System;
using System.IO;
namespace C_Sharp_Intermediate_By_Mosh.Extensibility034
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        //readonly string PATH = "/home/hasib/Projects/C_Sharp_Intermediate_By_Mosh/C_Sharp_Intermediate_By_Mosh";

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (StreamWriter sw = File.AppendText(_path + "/log.txt"))
            {
                sw.WriteLine(messageType + " : " + message);
            }
        }
    }
}
