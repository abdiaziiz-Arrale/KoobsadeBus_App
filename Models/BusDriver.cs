
namespace Models;
public class BusDriver
{
      public int Id { get; set; }

      public int UserId { get; set; }
      public User User { get; set; }

      public string DriverLisence { get; set; } = "";

      public String CarTrNo { get; set; } = "";
      public string TypeOfBus { get; set; } = "";

      public int NumberOfseats { get; set; }


      public bool IsVeriveid { get; set; }

      public DateTime CreateAt { get; set; }


}