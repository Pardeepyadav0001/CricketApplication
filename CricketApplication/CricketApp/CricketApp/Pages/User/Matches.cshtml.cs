using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CricketApp.Pages.User
{
    public class MatchesModel : PageModel
    {
        public List<MatchInfo> UpcomingMatches { get; set; } = new List<MatchInfo>
        {
            new MatchInfo { Teams = "Team A vs Team B", Date = new DateTime(2024, 2, 1) },
            new MatchInfo { Teams = "Team C vs Team D", Date = new DateTime(2024, 2, 15) },
            // Add more matches
        };

        public void OnGet()
        {
            // Load upcoming matches data
        }
    }

    public class MatchInfo
    {
        public string Teams { get; set; }
        public DateTime Date { get; set; }
    }
}
