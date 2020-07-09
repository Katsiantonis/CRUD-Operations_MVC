namespace AssignmentBrief.Migrations
{
    using AssignmentBrief.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentBrief.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssignmentBrief.Models.ApplicationDbContext context)
        {
            Trainer t1 = new Trainer() { FirstName = "Konstantinos", LastName = "Papadopoulos", Subject = "C#" };
            Trainer t2 = new Trainer() { FirstName = "Manolis", LastName = "Papas", Subject = "Java" };
            Trainer t3 = new Trainer() { FirstName = "Iakovos", LastName = "Xristou", Subject = "Javascript" };

            context.trainers.AddOrUpdate(x => x.FirstName, t1, t2, t3);

        }
    }
}
