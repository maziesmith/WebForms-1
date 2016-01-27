namespace Data.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Data.CarsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.CarsDbContext context)
        {
            if (context.Models.Count() == 0)
            {
                context.Extras.Add(new Extra { Name = "Extra 1" });
                context.Extras.Add(new Extra { Name = "Extra 2" });
                context.Extras.Add(new Extra { Name = "Extra 3" });

                var engines = new List<Engine>
                {
                    new Engine {Name = "Engine type 1" },
                    new Engine {Name = "Engine type 2" },
                    new Engine {Name = "Engine type 3" },
                };

                foreach (var engine in engines)
                {
                    context.Engines.Add(engine);
                }

                context.SaveChanges();

                var opel = new Producer { Name = "Opel" };
                context.Producers.Add(opel);
                context.SaveChanges();

                opel.Models.Add(new Model { Name = "Corsa", Producer = opel, Engine = engines[0] });
                opel.Models.Add(new Model { Name = "Vectra", Producer = opel, Engine = engines[1] });
                opel.Models.Add(new Model { Name = "Astra", Producer = opel, Engine = engines[2] });
                context.SaveChanges();

                var volkswagen = new Producer { Name = "Volkswagen" };
                context.Producers.Add(volkswagen);
                context.SaveChanges();

                volkswagen.Models.Add(new Model { Name = "Golf", Producer = volkswagen, Engine = engines[1] });
                volkswagen.Models.Add(new Model { Name = "Passat", Producer = volkswagen, Engine = engines[2] });
                context.SaveChanges();
            }
        }
    }
}
