using Microsoft.EntityFrameworkCore;
namespace HomeEase.Data
{
    public class UsersContext:DbContext
    {
     
    public UsersContext(DbContextOptions<UsersContext> options) : base(options) { }
    
    
    }
}
