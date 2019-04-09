using System;
using RD_University_DI.Core;

namespace RD_University_DI
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
