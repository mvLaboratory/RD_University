using System;
using RD_University_LSP.Models;

namespace RD_University_LSP
{
  public class RdUniversity
  {
    public int Execute()
    {
      Person booker = new Person(1)
      {
        FirstName = "John",
        LastName = "Doe",
        BirthDate = new DateTime(1996, 3, 10)
      };
      
      Room roomToBook = new RelaxRoom();

      roomToBook.BookTheRoom(booker);

      return 0;
    }

  }
}
