using Microsoft.AspNetCore.Http;
using RPG.Helpers;
using RPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Service
{
    public class SessionStorage
    {
        readonly ISession _session;

        const string STATSKEY = "STATS";
        const string LOCATIONKEY = "LOCATION";

        public User Stats { get; set; }

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            Stats = _session.Get<User>(STATSKEY);

        }

        public void SaveStats(User stats)
        {
            _session.Set(STATSKEY, stats);
        }

        public void SaveLocation(int loc)
        {
            _session.SetInt32(LOCATIONKEY, loc);
        }

        public int? GetLocation()
        {
            return _session.GetInt32(LOCATIONKEY);
        }

    }
}