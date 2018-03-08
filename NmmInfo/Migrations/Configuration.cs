namespace NmmInfo.Migrations
{
    using NmmInfo.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NmmInfo.Models.NmmInfo_Data>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

        }

        protected override void Seed(NmmInfo.Models.NmmInfo_Data context)
        {
            context.Breweries.AddOrUpdate(n => n.Name,
                new Brewery()
                {
                    Name = "Johnny's Hops",
                    Address = "Porter Lane",
                    City = "Empire",
                    State = "MI",
                    Zip = "49630"
                },
                new Brewery()
                {
                    Name = "Billy's Brew",
                    Address = "Stout Street",
                    City = "Cedar",
                    State = "MI",
                    Zip = "49635"
                },
                new Brewery()
                {
                    Name = "Suzy's Suds",
                    Address = "Amber Ave",
                    City = "Traverse City",
                    State = "MI",
                    Zip = "49686"
                }
                );
        }
    }
}
