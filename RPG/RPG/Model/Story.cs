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
                Description = "Nacházíš se na pláži a po náročném plavání jsi velice vyčerpán, můžeš se vyspat, nebo pokračovat v cestě.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Pokračovat", NextLocationId = 1}
                },
                CanSearchFood = false
            });

            locations.Add(1, new Location()
            {Id = 1, Name = "Pláž (tutorial)", Description = "Sice teď máš energie na rozdávání, ale zjistil jsi, že ti strašně kručí v břiše.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Pokračovat", NextLocationId = 2}
                },
                CanSleep = false
            });

            locations.Add(2, new Location()
            {Id = 2, Name = "Pláž (tutorial)", Description = "Teď jsi plný energie, ale v dálce vidíš bouři a začíná pršet.", 
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít hledat materiál na přístřešek do lesa", NextLocationId = 10},
                    new Path() { Id = 1, Description = "Jít hledat materiál na přístřešek na pláž", NextLocationId = 3},
                    new Path() { Id = 2, Description = "Jít hledat do lesa jeskyni", NextLocationId = 11},
                },
                CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(3, new Location()
            {Id = 3, Name = "Pláž", Description = "In PROGRESS"
            });

            //locations.Add(4, new Location()
            //{
            //    Id = 4,
            //    Name = "Pláž",
            //    Description = "Nacházíš se u jeskyně, ale slyšíš z ní podivné zvuky.",
            //    Paths = new List<Path>()
            //    {
            //        new Path() { Id = 1, Description = "Jít do jeskyně", NextLocationId = 20},
            //        new Path() { Id = 2, Description = "Hledat další jeskyni", NextLocationId = 12},
            //        new Path() { Id = 3, Description = "Jít zpátky na pláž", NextLocationId = 5}

            //    }
            //});

            locations.Add(5, new Location()
            {Id = 5, Name = "Pláž", Description = "In PROGRESS"
            });

            locations.Add(8, new Location()
            {
                Id = 8,
                Name = "ZEMŘEL JSI",
                Description = "Zemřel jsi hladem.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
                CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(9, new Location()
            {
                Id = 9,
                Name = "ZEMŘEL JSI",
                Description = "Zemřel jsi vyčerpáním.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
                CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });


            locations.Add(10, new Location()
            {
                Id = 10,
                Name = "ZEMŘEL JSI",
                Description = "Kvůli silnému větru na tebe spadl strom a ty jsi zemřel.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
                CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(11, new Location()
            { Id = 11,  Name = "Les", Description = "Nacházíš se u jeskyně, ale slyšíš z ní podivné zvuky.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít do jeskyně", NextLocationId = 20},
                    new Path() { Id = 1, Description = "Hledat další jeskyni", NextLocationId = 12},
                    new Path() { Id = 2, Description = "Jít zpátky na pláž", NextLocationId = 5}
                }
            });

            locations.Add(12, new Location()
            { Id = 12,  Name = "Les", Description = "Bouřka už je pryč, ale při hledání jeskyně si se ztratil.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Vylézt na strom a zorientovat se", NextLocationId = 20},
                    new Path() { Id = 1, Description = "Snažit se najít pláž", NextLocationId = 12},
                    new Path() { Id = 2, Description = "Jít zpátky na pláž", NextLocationId = 5}
                }
            });

            locations.Add(13, new Location()
            {
                Id = 13,
                Name = "Les",
                Description = "Naštěstí si praseti utekl.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít na pláž", NextLocationId = 5},
                }
            });

            locations.Add(14, new Location()
            { Id = 14, Name = "Les", Description = "Bouřka už je téměř pryč", 
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít na pláž", NextLocationId = 5},
                    new Path() { Id = 1, Description = "Zůstat v lese", NextLocationId = 12},
                }
            });

            locations.Add(15, new Location()
            {
                Id = 15,
                Name = "ZEMŘEL JSI",
                Description = "Prase se rozběhlo proti tobě a zabilo tě.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
                CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });



            locations.Add(20, new Location()
            { Id = 20,  Name = "Jeskyně", Description = "V jeskyni na tebe čekalo nemilé překvapení v podobě divokého prasete... Asi se nejspíš schvovávalo před bouřkou",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Utéct z jeskyně", NextLocationId = 13},
                    new Path() { Id = 1, Description = "Odejít z jeskyně", NextLocationId = 15},
                    new Path() { Id = 2, Description = "Bojovat s prasetem", NextLocationId = 21}
                },
                Achievement = new Achievement() { Name = "Jeskyňář", Description = "objevil si jeskyni" },
                CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(21, new Location()
            { Id = 21,  Name = "Jeskyně",  Description = "Souboj s prasetem si vyhrál. Bouřka je pryč",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít zpátky na pláž", NextLocationId = 5},
                },
                CanSearchFood = false,
            });
        }
    }
}