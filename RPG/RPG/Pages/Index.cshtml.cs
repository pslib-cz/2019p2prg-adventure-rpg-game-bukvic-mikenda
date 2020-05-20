using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RPG.Model;
using RPG.Service;

namespace RPG.Pages
{
    public class IndexModel : PageModel
    {
        readonly SessionStorage _session;

        public User Stats { get; set; }

        public IndexModel(SessionStorage session)
        {
            _session = session;
        }

        public void OnGet()
        {
            Stats = new User();
            _session.SaveStats(Stats);
        }
    }
}
