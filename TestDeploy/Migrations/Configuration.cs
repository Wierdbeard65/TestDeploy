namespace TestDeploy.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TestDeploy.Models.TestDeployContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TestDeploy.Models.TestDeployContext context)
        {
        }
    }
}
