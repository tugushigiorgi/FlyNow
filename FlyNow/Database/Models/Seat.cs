namespace FlyNow.Database.Models;

public class Seat
{
    
    public Guid Id { get; set; }
    public SeatType SeatType { get; set; }
    
    public Aircraft Aircraft { get; set; }
    public Guid AircraftId { get; set; }

    
    public string SeatLocation { get; set; }
    
    
    
    
    public Avaiability Avaiability { get; set; }

    
    
    
    
    
    
    
}