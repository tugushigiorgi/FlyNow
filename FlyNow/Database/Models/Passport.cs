namespace FlyNow.Database.Models;

public class Passport
{
    
    
    public Guid Id { get; set; }
    
    public User user { get; set; }
    
    
    
    public string PassportNumber { get; set; }
    
    public DateTime DateOfIssue { get; set; }
    
    public DateTime DateOfExpiry { get; set; }
    
    public string CountryofIssue { get; set; }
    
    
    public string PlaceofIssue { get; set; }
    public string VisaInformation { get; set; }

    
    
    
    

}