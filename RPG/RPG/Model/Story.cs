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
                Name = "Pláž (tutorial)",
                Description = "Nacházíš se na pláži a po náročném plavání jsi velice vyčerpán(-> Energy), proto si musíš chvíli prospat",
                //metoda na zvýšení hodnoty spánku (energy)
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Vyspat se", NextLocationId = 1},
                }
            });

            locations.Add(1, new Location()
            {
                Id = 1,
                Name = "Pláž (tutorial)",
                Description = "Sice teď máš energie na rozdávání, ale zjistil jsi, že ti strašně kručí v břiše",
                // metoda na hledání jídla
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Najíst se", NextLocationId = 2},
                }
            });

            locations.Add(2, new Location()
            {
                Id = 2,
                Name = "Pláž (tutorial)",
                Description = "Teď jsi plný energie, ale v dálce vidíš bouři a začíná pršet",
                // metoda na hledání jídla
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít hledat materiál na přístavek do lesa", NextLocationId = 10},
                    new Path() { Id = 1, Description = "Jít hledat materiál na přístavek na pláž", NextLocationId = 3},
                    new Path() { Id = 2, Description = "Jít hledat do lesa jeskyni a schovat se do ní", NextLocationId = 11},
                }
            });




            locations.Add(10, new Location()
            {
                Id = 10,
                Name = "Les",
                Description = "Díky silnému větru na tebe sklátil strom a ty jsi zemřel",
            });

            locations.Add(11, new Location()
            {
                Id = 11,
                Name = "Les",
                Description = "Nacházíš se u jeskyně, ale slyšíš z ní podivné zvuky.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 1, Description = "Jít do jeskyně", NextLocationId = 20},
                    new Path() { Id = 2, Description = "Hledat další jeskyni", NextLocationId = 12},
                    new Path() { Id = 3, Description = "Jít zpátky na pláž", NextLocationId = 4}

                }
            });

            locations.Add(20, new Location()
            {
                Id = 20,
                Name = "Jeskyně",
                Description = "Nacházíš se v jeskyni.",
                Paths = new List<Path>()
                {
                }
            });

            locations.Add(30, new Location()
            {
                Id = 30,
                Name = "Les",
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