namespace FlyNow.Database.Models;

public class Airport
{
    
    
    public Guid Id { get; set; }
    
    public string AirPortName { get; set; }

    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    
    
    
    public string IATA { get; set; }
    
    public string ICAO { get; set; }
    
    public List<string> Facilities { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }


    public List<AirLine> Airlines;


}