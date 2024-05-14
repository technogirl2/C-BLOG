using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace blog.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }




    }
}