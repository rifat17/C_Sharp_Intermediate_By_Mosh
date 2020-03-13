namespace C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Composition
{
    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            logger.Log("We are installing..");
        }
    }
}
