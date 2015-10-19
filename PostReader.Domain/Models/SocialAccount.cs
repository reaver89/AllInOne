
namespace PostReader.Data.Models
{
    public class SocialAccount
    {
        public int SocialAccountId { get; set; }
        public User User { get; set; }
        public SocialAccountType Type { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
    }
}
