using Microsoft.AspNetCore.Identity;

namespace WebStory.Domain.Entities.Identity
{
    public class User : IdentityUser
    {
        public const string Administrator = "Admin";
        public const string AdminDefaultPassword = "AdminPassword";
    }
}
