using Microsoft.AspNetCore.Identity;

namespace WebStory.Domain.Entities.Identity
{
    public class Role : IdentityRole
    {
        public const string Administrator = "Administrators";
    }
}
