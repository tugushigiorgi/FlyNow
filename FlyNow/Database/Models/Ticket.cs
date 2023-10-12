namespace FlyNow.Database.Models;

public class Ticket
{
    
   public Guid Id { get; set; }

    public Booking Booking { get; set; }

    public Guid BookingId { get; set; }


 

   
    public string QrCode { get; set; }
    
    
    





}