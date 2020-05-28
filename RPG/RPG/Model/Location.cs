using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Model
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLocked { get; set; }
        public bool CanSleep { get; set; } = true;
        public bool CanSearchFood { get; set; } = true;
        public bool ShowStats { get; set; } = true;
        public List<Path> Paths { get; set; }     
        public Achievement Achievement { get;set; }
    }
       
}