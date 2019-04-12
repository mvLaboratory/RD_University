using System;
using System.Linq;
using RD_University.Core;
using RD_University.Interfaces;
using RD_University_SRP.Core;
using RD_University_SRP.Data;
using RD_University_SRP.Models;

namespace RD_University_SRP
{
  class ConsoleProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("===RD University!===\n");
      Console.WriteLine("What you want to do?");

      var university = ServiceFactory.GetUniversity();
      university.Execute();

      Console.ReadKey();
    }
  }
}
