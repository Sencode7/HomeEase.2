using HomeEase.Models;
using Microsoft.EntityFrameworkCore;
namespace HomeEase.Data
{
    public class UserContext:DbContext
    {
     
    public UserContext(DbContextOptions<UserContext> options) : base(options) { }
    
    public DbSet<Landlord> Landlords {  get; set; }
    }
}
