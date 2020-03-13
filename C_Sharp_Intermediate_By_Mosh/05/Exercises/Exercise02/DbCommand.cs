using System;
using C_Sharp_Intermediate_By_Mosh.Exercises.Exercise01;
namespace C_Sharp_Intermediate_By_Mosh.Exercises.Exercise02
{
    public class DbCommand
    {
        private readonly DbConnection dbConnection;
        public string Instruction { get; private set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Instruction could not be empty or null");
            this.dbConnection = dbConnection;
            Instruction = instruction;
        }

        public void Execute()
        {
            dbConnection.Open();
            Console.WriteLine("Executed " + Instruction );
            dbConnection.Close();
        }
    }
}
