using System;
namespace C_Sharp_Intermediate_By_Mosh.Exercises.Exercise01
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection Closed");
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection Opened");
        }
    }
}
