using System;
namespace C_Sharp_Intermediate_By_Mosh.Exercises.Exercise01
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; set; }

        protected DbConnection(string connectionString)
        {
            if (connectionString == null)
                throw new InvalidOperationException("Connection String Could not be null");
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
