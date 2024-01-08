using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CricketApp.Pages.User
{
    public class SettingsModel : PageModel
    {
        public string ApplicationName { get; set; } = "Cricket App";
        public int MaxPlayers { get; set; } = 11;
        // Add more properties for additional settings
    }
}
