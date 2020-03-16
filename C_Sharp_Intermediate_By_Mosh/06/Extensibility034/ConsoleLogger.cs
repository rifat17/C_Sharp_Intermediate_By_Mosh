using System;
namespace C_Sharp_Intermediate_By_Mosh.Extensibility034
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("ERROR : " + message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("INFO : " + message);
        }
    }
}
