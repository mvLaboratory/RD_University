using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University_LSP.Models
{
  public class Room
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public int Number { get; set; }

    public virtual void BookTheRoom(Person booker)
    {
      throw new NotSupportedException("Could not book the unspecified room!");
    }
  }

  class RelaxRoom : Room
  {
    public override void BookTheRoom(Person booker)
    {
      Console.WriteLine($"The Relax room was booked by {booker.FirstName} {booker.LastName}");
    }
  }

  class MeetingRoom : Room
  {
    public override void BookTheRoom(Person booker)
    {
      Console.WriteLine($"The Meeting room was booked by {booker.FirstName} {booker.LastName}");
    }
  }

  class ConferenceRoom : Room
  {
    public override void BookTheRoom(Person booker)
    {
      Console.WriteLine($"The Conference room was booked by {booker.FirstName} {booker.LastName}");
    }
  }

  class ReadingRoom : Room
  {
    public override void BookTheRoom(Person booker)
    {
      Console.WriteLine($"The Reading room was booked by {booker.FirstName} {booker.LastName}");
    }
  }
}
