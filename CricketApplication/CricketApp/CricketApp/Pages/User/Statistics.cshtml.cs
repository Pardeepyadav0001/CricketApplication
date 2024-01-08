using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CricketApp.Pages.User
{
    public class StatisticsModel : PageModel
    {
        public int TotalMatches { get; set; } = 50;
        public int TotalRuns { get; set; } = 1500;
        // Add more properties for different statistics

        public void OnGet()
        {
            // Load cricket statistics data
        }
    }
}
