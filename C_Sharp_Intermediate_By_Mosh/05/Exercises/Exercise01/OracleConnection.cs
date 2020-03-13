using System;
namespace C_Sharp_Intermediate_By_Mosh.Exercises.Exercise01
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection Closed");
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection Opened");
        }
    }
}
