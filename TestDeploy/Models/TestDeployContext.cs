namespace TestDeploy.Models
{
    using System.Data.Entity;
    public partial class TestDeployContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDeployContext"/> class.
        /// </summary>
        public TestDeployContext() : base("DefaultConnection")
        {
        }
    }
}