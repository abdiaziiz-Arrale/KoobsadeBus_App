

namespace Models;
public class Admin
{
      public int Id { get; set; }

      public bool IsVeriveid { get; set; }

      public decimal TickedPrice  { get; set; }

      public string Cities { get; set; }="";
      public Decimal Revune { get; set; }

      public bool IsDesiable { get; set; }

      public DateTime CreateAt {get;set;}


}