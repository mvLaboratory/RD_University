using System;
using System.Collections.Generic;
using System.Text;
using RD_University_LSP.Interfaces;

namespace RD_University_LSP.Models
{
  public class Room
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public int Number { get; set; }
  }

  public abstract class BoockableRoom : Room, IBookable
  {
    public Person Booker { get; set; }
    public DateTime BookDate { get; set; }
    public abstract void BookTheRoom(BookablePerson booker);
  }

  class RelaxRoom : BoockableRoom
  {
    public override void BookTheRoom(BookablePerson booker)
    {
      Console.WriteLine($"The Relax room was booked by {booker.FirstName} {booker.LastName}");
    }
  }

  class MeetingRoom : BoockableRoom
  {
    public override void BookTheRoom(BookablePerson booker)
    {
      Console.WriteLine($"The Meeting room was booked by {booker.FirstName} {booker.LastName}");
    }
  }

  class ConferenceRoom : BoockableRoom
  {
    public override void BookTheRoom(BookablePerson booker)
    {
      Console.WriteLine($"The Conference room was booked by {booker.FirstName} {booker.LastName}");
    }
  }

  class ReadingRoom : Room
  {

  }
}
