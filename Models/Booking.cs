
namespace Models;
public class Booking
{
      
	public int Id { get; set; }
	public User User { get; set; }

     public Schedule Schedule {get; set;}
	public string Present { get; set; }="";

      public string Going { get; set; }="";

     public DateTime DayAndTime { get; set; }

	public decimal PaidAmount { get; set; }

	public decimal Commission { get; set; }


	public string PaymentMethod { get; set; } = "";
	public string TransactionId { get; set; } = "";


	public decimal DriverRevenue { get; set; }
	public bool IsCompleted { get; set; }

	public DateTime CreatedAt { get; set; }
}