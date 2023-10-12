namespace FlyNow.Database.Models;

public class AirLine
{
    
    public Guid Id { get; set; }
    
    public string AirLineName { get; set; }
    
    
    public string IATA { get; set; }
    
    public string ICAO { get; set; }
    
    public string Logo { get; set; }
    
    public string phone { get; set; }
    
    public string Email { get; set; }
    
    public string Description { get; set; }
    
    public List<Aircraft> Fleet { get; set; }
    
    public List<Airport> Airports { get; set; }
    
    public string Baggage { get; set; }
    
    public List<string> CheckinOptions { get; set; }
    
    
    public List<string> InFlightServices { get; set; }
    
    
    
    
    
    
    
    
}