using System;
namespace C_Sharp_Intermediate_By_Mosh.Extensibility034
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator( ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.LogInfo("Migrating start " + DateTime.Now);


            //WORKS


            logger.LogInfo("Migrating finished " + DateTime.Now);
        }
    }
}
