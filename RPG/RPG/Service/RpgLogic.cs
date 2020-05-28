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
            if (path == 0) { Stats.Energy = 35; Stats.Food = 50; }

            _session.SaveLocation(current);

            Stats.Energy -= _rand.Next(5, 10);
            Stats.Food -= _rand.Next(10, 15);

            if (Stats.Food < 1) return _story.locations[8];
            if (Stats.Energy < 1) return _story.locations[9];

            _session.SaveStats(Stats);

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

            return _story.locations[current];
        }

        public Location Sleep()
        {
            int current = _session.GetLocation().GetValueOrDefault();
            _story.locations[current].CanSleep = false;

            Stats.Energy += _rand.Next(20, 50);
            Stats.Food -= _rand.Next(5, 15);

            if (Stats.Food > 100) Stats.Food = 100;
            else if (Stats.Food < 1) return _story.locations[8];

            if (Stats.Energy > 100) Stats.Energy = 100;
            else if (Stats.Energy < 1) return _story.locations[9];

            _session.SaveStats(Stats);
            return _story.locations[current];
        }

        public Location SearchFood()
        {
            int current = _session.GetLocation().GetValueOrDefault();
            _story.locations[current].CanSearchFood = false;

            Stats.Food += _rand.Next(50, 80);
            Stats.Energy -= _rand.Next(10, 20);

            if (Stats.Food > 100) Stats.Food = 100;
            else if (Stats.Food < 1) return _story.locations[8];

            if (Stats.Energy > 100) Stats.Energy = 100;
            else if (Stats.Energy < 1) return _story.locations[9];

            _session.SaveStats(Stats);
            return _story.locations[current];
        }
    }
}
