using System.Data.Entity.Migrations;
using Heuristics.TechEval.Core.Models;

namespace Heuristics.TechEval.Core.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

	        context.Members.AddOrUpdate(
		        new Member {Email = "sjohnson@heuristics.net", Name = "Seth Petry-Johnson"},
		        new Member {Email = "sreed@heuristics.net", Name = "Scott Reed"},
		        new Member {Email = "callen@heuristics.net", Name = "Calvin Allen"}
			);

	        context.Categories.AddOrUpdate(
		        new Category {Name = "Software Developer"},
		        new Category {Name = "Director of Application Development"}
	        );
        }
    }
}
