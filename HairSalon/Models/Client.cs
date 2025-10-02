using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public Client() {
      this.JoinEntities = new HashSet<StylistClient>();
    }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public string Notes { get; set; }
    public string DateOfLastApp { get; set; }
    public int StylistId { get; set; }
    
    public virtual ICollection<StylistClient> JoinEntities { get; }
  }
}