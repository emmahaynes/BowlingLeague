using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Emma Haynes 4-1-21

namespace BowlingLeague.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            //Saves the teamname as the selected type to compare in the default.cshtml to highlight 
            //selected team in navigation
            ViewBag.SelectedType = RouteData?.Values["teamname"];

            //get list of teams and order them to be used in navigation
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
