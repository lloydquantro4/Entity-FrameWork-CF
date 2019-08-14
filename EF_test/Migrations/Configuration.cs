namespace EF_test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_test.SchoolDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EF_test.SchoolDB context)
        {
            //  This method will be called after migrating to the latest version

            //you can put your seed method here executed after every migration
        }
    }
}
