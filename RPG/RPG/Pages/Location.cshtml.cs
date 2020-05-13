using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Service;
using RPG.Model;

namespace RPG.Pages
{
    public class LocationModel : PageModel
    {
        readonly SessionStorage _session;
        readonly RpgLogic _rpgLogic;

        public Location location { get; set; }

        public LocationModel(SessionStorage session, RpgLogic rpgLogic)
        {
            _session = session;
            _rpgLogic = rpgLogic;
        }

        public void OnGet()
        {
            location = _rpgLogic.Play();
        }
    }
}