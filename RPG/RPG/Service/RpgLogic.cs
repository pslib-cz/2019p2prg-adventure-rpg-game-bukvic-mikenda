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

        public RpgLogic(SessionStorage session, Story story)
        {
            _session = session;
            _story = story;
        }

        public Location Play()
        {
            return _story.locations[0];
        }
    }
}
