using RPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Service
{
    public class RpgLogic
    {
        readonly SessionStorage _session;
        readonly Story _story;
        readonly Random _rand;

        public User Stats { get; set; }

        public RpgLogic(SessionStorage session, Story story, Random rand)
        {
            _session = session;
            _story = story;
            _rand = rand;

            Stats = new User() { 
                Food = _session.Stats.Food,
                Energy = _session.Stats.Energy
            };
        }

        public Location Play(int path)
        {
            _session.SaveStats(Stats);
            return _story.locations[path];
        }

        public void Sleep()
        {
            Stats.Energy += _rand.Next(20, 50);
            Stats.Food -= _rand.Next(5, 15);
            _session.SaveStats(Stats);
        }

        public void SearchFood()
        {
            Stats.Food += _rand.Next(50, 80);
            Stats.Energy -= _rand.Next(10, 20);
            _session.SaveStats(Stats);
        }
    }
}
