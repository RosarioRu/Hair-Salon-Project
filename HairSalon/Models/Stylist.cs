//using System.Collections.Generic; (for lists)


namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId {get; set }
    public string StylistFirstName {get; set }
    public string StylistLastName {get; set }
    public string StylistSpecialty {get; set }
    public virtual ICollection<Client> Clients { get; set; }

    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    } //will return all clients that belong to a stylist

  }
}