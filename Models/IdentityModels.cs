using Microsoft.AspNet.Identity.EntityFramework;


namespace Wakency.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string fname { get; set; }
        public string lname {  get; set;}
        public string email { get; set;}
        public string contact { get; set;}
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}