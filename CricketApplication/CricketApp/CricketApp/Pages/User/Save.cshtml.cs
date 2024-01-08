using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CricketApp.Pages.User
{
    public class SaveModel : PageModel
    {
        [BindProperty]
        public string ApplicationName { get; set; }
        [BindProperty]
        public int MaxPlayers { get; set; }
        // Add more properties for additional settings

        public IActionResult OnPost()
        {
            // Save the edited settings (You may save to a database or configuration file)
            // For simplicity, redirect back to the settings page
            return RedirectToPage("Settings");
        }
    }
}
