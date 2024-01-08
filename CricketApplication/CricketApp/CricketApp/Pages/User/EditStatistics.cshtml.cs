using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CricketApp.Pages.User
{
    public class EditStatisticsModel : PageModel
    {
        [BindProperty]
        public int TotalMatches { get; set; }

        [BindProperty]
        public int TotalRuns { get; set; }
        // Add more properties for different statistics

        public void OnGet()
        {
            // Load cricket statistics data for editing
        }

        public IActionResult OnPost()
        {
            // Save the edited cricket statistics
            // For simplicity, redirect back to the cricket statistics page
            return RedirectToPage("Statistics");
        }
    }
}
