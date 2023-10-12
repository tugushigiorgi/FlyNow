using FlyNow.Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlyNow.Database;
 
public class FlyNowDbContext : IdentityDbContext<User,UserRole,Guid>
{
    
    public FlyNowDbContext(DbContextOptions db) : base(db) {}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     }   
        
    


}