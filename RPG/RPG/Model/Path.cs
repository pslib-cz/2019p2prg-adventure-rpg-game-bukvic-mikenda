using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Model
{
    public class Path
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int NextLocationId { get; set; }
    }
}