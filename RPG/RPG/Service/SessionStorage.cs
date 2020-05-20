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

    }
}