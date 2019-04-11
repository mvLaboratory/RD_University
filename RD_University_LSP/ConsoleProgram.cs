using System;

namespace RD_University_LSP
{
  class ConsoleProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("===RD University!===\n");
      var university = new RdUniversity();

      university.Execute();
      Console.ReadKey();
    }
  }
}
