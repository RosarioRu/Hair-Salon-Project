using System.Collections.Generic;
// using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientFirstName { get; set; }
    public string ClientLastName { get; set; }
    public string  ClientPhoneNumber {get; set; }
    public int StylistId {get; set; }
    public virtual Stylist Stylist {get; set; }

  }
}