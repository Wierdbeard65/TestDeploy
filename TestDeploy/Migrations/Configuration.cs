namespace TestDeploy.Migrations
{
    using System.Data.Entity.Migrations;
    using TestDeploy.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestDeploy.Models.TestDeployContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TestDeploy.Models.TestDeployContext context)
        {
            Thing thing = new Thing() { Name = "Thing 1" };
            context.Things.Add(thing);
            thing = new Thing() { Name = "Thing 2" };
            context.Things.Add(thing);
        }
    }
}
