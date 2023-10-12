using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using FlyNow.Database.Enums;
using Microsoft.AspNetCore.Identity;

namespace FlyNow.Database.Models;

public class User :IdentityUser<Guid>
{
   
    [Required]    
    public string Surname { get; set; } 
    
        
    [Required] 
    public UserRole Role { get; set; }

    [Required] 
    public Gender Gender;
    
    
    public string? ProfilePicture { get; set; }
    
    [JsonIgnore]
    public List<Booking> Bookings { get; set; }
    
    [Required] 
    public DateTime Birthday { get; set; }

    
    public Passport? Passport { get; set; }
    
    
    
    
    
    
    
    
    
    [JsonIgnore]
    public override string PasswordHash
    {
        get => base.PasswordHash;
        set => base.PasswordHash = value;
    }
    
    
    
    
    
}