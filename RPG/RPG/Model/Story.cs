using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Model
{
    public class Story
    {
        public Dictionary<int, Location> locations = new Dictionary<int, Location>();
        public Story()
        {
            locations.Add(0, new Location()
            {
                Id = 0,
                Name = "První lokace",
                Description = "Nacházíš se v první lokaci.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 1, Description = "Jít do druhé lokace", NextLocationId = 10},
                    new Path() { Id = 2, Description = "Jít do třetí lokace", NextLocationId = 20},
                    new Path() { Id = 3, Description = "Jít do čtvrté lokace", NextLocationId = 30},
                }
            });

            locations.Add(10, new Location()
            {
                Id = 10,
                Name = "Druhá lokace",
                Description = "Nacházíš se v druhé lokaci.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 1, Description = "Jít do první lokace", NextLocationId = 0},
                    new Path() { Id = 2, Description = "Jít do třetí lokace", NextLocationId = 20},
                }
            });
        }
    }
}