using System;
using System.Collections.Generic;
using System.Text;
using RD_University_LSP.Models;

namespace RD_University_LSP.Interfaces
{
  interface IBookable
  {
    void BookTheRoom(BookablePerson booker);
  }
}
