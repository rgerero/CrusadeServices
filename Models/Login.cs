namespace CrusadeServices.Models
{
    public class Login
    {
        public string Username { get; set; } = string.Empty;
        public string? Password { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
