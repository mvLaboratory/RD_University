using System;
using RD_University_ISP.Core;

namespace RD_University_ISP
{
  public class ConsoleProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("===RD University!===\n");
      var university = ServiceFactory.CreateRdUniversity();

      int executionResult;
      do
      {
        Console.WriteLine("What you want to do?");
        executionResult = university.Execute();
        Console.WriteLine();
      }
      while (executionResult == 1);
    }
  }
}
