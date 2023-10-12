using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace FlyNow.Database.Models;

public class User :IdentityUser<Guid>
{
   
    [Required]
    public string Surname;
    [Required]
    public UserRole Role;

    public string? ProfilePicture;
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    [JsonIgnore]
    public override string PasswordHash
    {
        get => base.PasswordHash;
        set => base.PasswordHash = value;
    }
    
    
    
    
    
}