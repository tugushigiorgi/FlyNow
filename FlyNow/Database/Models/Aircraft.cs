namespace FlyNow.Database.Models;

public class Aircraft
{
    
    public Guid Id { get; set; }

    public string Model { get; set; }


    public bool isFull { get; set; } = false;
    
            
    public List<Seat> Seats { get; set; }
    
    public Flight Flight { get; set; }
    
    public Guid FlightId { get; set; }

    


}