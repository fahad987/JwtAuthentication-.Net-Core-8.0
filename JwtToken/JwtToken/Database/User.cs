using Microsoft.AspNetCore.Identity;

namespace JwtToken.Database;

public class User : IdentityUser
{
    public string?  Initials { get; set; }
}