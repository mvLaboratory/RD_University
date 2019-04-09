using System;
using System.Linq;
using RD_University_SRP.Core;
using RD_University_SRP.Data;

namespace RD_University_SRP
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("===RD University!===\n");
      Console.WriteLine("What you want to do?");

      var dataProvider = new StudentDataProvider();
      var consoleReaderWriter = new ConsoleReaderWriter();
      var printerWriter = new PrinterWriter();

      var students = dataProvider.GetStudents();

      var input = consoleReaderWriter.Read();
      switch (input)
      {
        case "s":
          students.ToList().ForEach(consoleReaderWriter.Write);
          break;
        case "p":
          students.ToList().ForEach(printerWriter.Write);
          break;
      }       

      Console.ReadKey();
    }
  }
}
