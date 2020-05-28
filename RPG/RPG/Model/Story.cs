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
            //pláž 0 - 19
            //les 20 - 29
            //jeskyně 30 - 39
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
            {
                Id = 1,
                Name = "Pláž (tutorial)",
                Description = "Sice teď máš energie na rozdávání, ale zjistil jsi, že ti strašně kručí v břiše.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Pokračovat", NextLocationId = 2}
                },
                CanSleep = false
            });

            locations.Add(2, new Location()
            {
                Id = 2,
                Name = "Pláž (tutorial)",
                Description = "Konečně už nemáš ten ukrutný hlad, ale v dálce vidíš bouři a začíná pršet.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít hledat materiál na přístřešek na pláž", NextLocationId = 3},
                    new Path() { Id = 1, Description = "Jít hledat materiál na přístřešek do lesa", NextLocationId = 20},
                    new Path() { Id = 2, Description = "Jít hledat do lesa jeskyni", NextLocationId = 21}
                },
                CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(3, new Location()
            {
                Id = 3,
                Name = "Pláž",
                Description = "Zatím jsi nic nenašel. Bouře už je teméř na ostrově, chceš pokračovat ve hledání",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Pokračovat v hledání na pláži.", NextLocationId = 4},
                    new Path() { Id = 1, Description = "Jít hledat materiál na přístřešek do lesa", NextLocationId = 20},
                    new Path() { Id = 2, Description = "Jít hledat do lesa jeskyni", NextLocationId = 21}
                },
            });

            locations.Add(4, new Location()
            {
                Id = 4,
                Name = "Zemřel jsi",
                Description = "Díky bouřce do tebe vrazil blesk.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
                CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(5, new Location()
            {
                Id = 5,
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

            locations.Add(6, new Location()
            {
                Id = 6,
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

            locations.Add(20, new Location()
            {
                Id = 20,
                Name = "Les",
                Description = "Při bouřce si se ztratil v lese. Naštěstí bouřka už je téměř pryč",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Snažit se najít pláž", NextLocationId = 22},
                    new Path() { Id = 1, Description = "Vylézt na strom a zorientovat se", NextLocationId = 23}
                },
                CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(21, new Location()
            {
                Id = 21,
                Name = "Les",
                Description = "Nacházíš se u jeskyně, ale slyšíš z ní podivné zvuky.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Jít zpátky na pláž", NextLocationId = 22},
                    new Path() { Id = 1, Description = "Hledat další jeskyni", NextLocationId = 21},
                    new Path() { Id = 2, Description = "Jít do jeskyně", NextLocationId = 30}
                },
                CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(22, new Location()
            {
                Id = 22,
                Name = "Zemřel jsi",
                Description = "Při hledání pláže si zapadl do pohyblivého písku",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
                CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(23, new Location()
            {
                Id = 23,
                Name = "Les",
                Description = "Jsi v půlce stromu a témeř nic nevidíš.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Vylézt na špičku", NextLocationId = 25},
                    new Path() { Id = 1, Description = "Vrátit se na zem", NextLocationId = 26}
                },
		        CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(25, new Location()
            {
                Id = 25,
                Name = "Zemřel jsi",
                Description = "Foukal silný vítr a ty jsi spadl.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
		        CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(26, new Location() //dodělat
            {
                Id = 26,
                Name = "Les",
                Description = "Bouřka už je naštěstí pryč.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "IN PROGRESS - Začít znovu", NextLocationId = 0},
                },
		        CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(27, new Location()
            {
                Id = 27,
                Name = "Lese",
                Description = "Praseti jsi naštěstí utekl.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "IN PROGRESS - Začít znovu", NextLocationId = 0},
                },
		        CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(30, new Location()
            {
                Id = 30,
		        Name = "Jeskyně", Description = "V jeskyni na tebe čekalo nemilé překvapení v podobě divokého prasete... Asi se nejspíš schvovávalo před bouřkou",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "Utéct z jeskyně", NextLocationId = 27},
                    new Path() { Id = 1, Description = "Odejít z jeskyně", NextLocationId = 31},
                    new Path() { Id = 2, Description = "Bojovat s prasetem", NextLocationId = 32}
                },
                Achievement = new Achievement() { Name = "Jeskyňář", Description = "objevil si jeskyni" },
                CanSearchFood = false,
                CanSleep = false
            });

            locations.Add(31, new Location()
            {
                Id = 31,
		        Name = "Zemřel jsi",
                Description = "Prase tě dohnalo.",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "ZAČÍT ZNOVU", NextLocationId = 0},
                },
		        CanSearchFood = false,
                CanSleep = false,
                ShowStats = false
            });

            locations.Add(32, new Location()
            {
                Id = 32,
		        Name = "Jeskyně",
                Description = "Souboj jsi vyhrál. A bouřka je pryč",
                Paths = new List<Path>()
                {
                    new Path() { Id = 0, Description = "IN PROGRESS - Začít znovu", NextLocationId = 0},
                },
                Achievement = new Achievement() { Name = "Jatkář", Description = "vyhrál jsi souboj s prasetem" },
                CanSearchFood = false,
                CanSleep = false,
		        ShowStats = false
            });
        }
    }
}