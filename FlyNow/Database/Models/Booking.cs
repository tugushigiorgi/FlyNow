namespace FlyNow.Database.Models;

public class Booking
{
    public Guid Id { get; set; }

    public User user { get; set; }

    public Guid UserId { get; set; }
    
    public Flight Flight { get; set; }
    
    public DateTime BookingDate { get; set; }

    public double Price { get; set; }
    
    public BookingStatus  Status { get; set; }
     
    public Seat Seat { get; set; }
    
    
    
      





}