
    public class UserRepository
    {
        public static bool ValidateCredentials(string username, string password)
        {
            // Implement logic to validate user credentials against a database
            // Use secure password hashing methods
            // Example: Query the database
            // For demo purposes, using a simple example
            return username == "IAmRajababu" && password == "MyPassword";
        }

        public static string GetUserRole(string username)
        {
            // Implement logic to retrieve user role from a database
            // Example: Query the database
            // For demo purposes, returning a hardcoded value
            return "Admin";
        }
    }