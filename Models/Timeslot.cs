namespace Models;


public class Timeslot
{
      public int Id { get; set; }

      public BusDriver BusDriver { get; set; }=new();

      public string TravelBegan { get; set; } = "";
      public string TravelEnd { get; set; } = "";

      public int NumberOfPassengers { get; set; }

      public DateTime CreateAt { get; set; }
}
