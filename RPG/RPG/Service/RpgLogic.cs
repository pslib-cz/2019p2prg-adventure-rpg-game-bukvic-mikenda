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
                Energy = _session.Stats.Energy,
                Achievements = _session.Stats.Achievements
            };
        }

        public Location Play(int path)
        {
            int current = 0;
            if (path != 0) current = _session.GetLocation().GetValueOrDefault();
            
            _session.SaveLocation(current);

            Achievement achievement = _story.locations[current].Achievement;
            if (achievement != null)
            {
                Stats.Achievements.Add(new Achievement() { Description = achievement.Description, Name = achievement.Name });
                _session.SaveStats(Stats);
                
            }

            if (_story.locations[current].Paths.Any(i => i.NextLocationId == path))
            {
                _session.SaveLocation(path);
                return _story.locations[path];
            }

            _session.SaveStats(Stats);
            return _story.locations[current];
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
