namespace FlyNow.Database.Models;

public class Flight
{

    public Guid Id { get; set; }


    public AirLine Airline { get; set; }

    public List<Booking> Booking { get; set; }
    
        
    
    
    public Airport DepartureAirport { get; set; }
    
    public Airport ArrivalAirport { get; set; }

    public DateTime DepartureDate { get; set; }

    public DateTime ArrivalDate { get; set; }


    public string Gate { get; set; }
    
    public Aircraft Aircraft { get; set; }
    
    




}