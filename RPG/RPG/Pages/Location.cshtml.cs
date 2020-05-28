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
        readonly RpgLogic _rpgLogic;

        public Location location { get; set; }
        public User Stats { get; set; }

        public LocationModel(RpgLogic rpgLogic)
        {
            _rpgLogic = rpgLogic;
        }

        public void OnGet(int path)
        {
            Stats = _rpgLogic.Stats;
            location = _rpgLogic.Play(path);
        }

        public void OnGetSleep()
        {
            location = _rpgLogic.Sleep();
            Stats = _rpgLogic.Stats;
        }

        public void OnGetSearchFood()
        {
            location = _rpgLogic.SearchFood();
            Stats = _rpgLogic.Stats;
        }

    }
}