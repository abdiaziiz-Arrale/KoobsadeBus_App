namespace Models;

public class Schedule 
{
      public int Id { get; set; }

      public BusDriver BusDriver { get; set; }=new();
      public string Seat { get; set; }="";
	
      public bool IsAvailable  { get; set; }
      
      public DateTime CreateAt { get; set; }
}