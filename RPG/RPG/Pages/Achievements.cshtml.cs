using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Service;
using RPG.Model;

namespace RPG
{
    public class AchievementsModel : PageModel
    {
        readonly RpgLogic _rpgLogic;
        public User Stats { get; set; }
        public AchievementsModel(RpgLogic rpgLogic)
        {
            _rpgLogic = rpgLogic;
        }

        public void OnGet()
        {
            Stats = _rpgLogic.Stats;
        }
    }
}