using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence
{
   public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {
                var activites = new List<Activity> {
                    new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 1",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                     new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 2",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                      new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 3",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                       new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 4",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                        new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 5",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                         new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 6",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                          new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 7",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                           new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 8",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                            new Activity{
                        Title="",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 9",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    },
                            new Activity{
                        Title="tset 10",
                        Date=DateTime.Now.AddMonths(-2),
                        Description="tset 1",
                        Category="drinks",
                        City="London",
                        Venue="Pub"
                    }
                };
                context.Activities.AddRange(activites);
                context.SaveChanges();
            }
            
        }
    }
}
