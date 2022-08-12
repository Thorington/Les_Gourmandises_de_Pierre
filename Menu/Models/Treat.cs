using System.Collections.Generic;

namespace Menu.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Title { get; set; }
    public string Instructions { get; set; }
    public string Ingredients { get; set; }
    public string Rating { get; set; }
    public virtual ApplicationUser User { get; set; } //new line

    public virtual ICollection<FlavorTreat> JoinEntities { get;}
  }
}