using System;
using System.Collections.Generic;
using System.Linq;
using RD_University.Core;
using RD_University.Data;
using RD_University.Models;

namespace RD_University
{
  class Program
  {
    static void Main(string[] args)
    {
      var readerWriter = new ConsoleReaderWriter();
      var printerWriter = new PrinterWriter();

      readerWriter.WriteLine("===RD University!===\n");
      readerWriter.WriteLine("What you want to do?");

      var dataProvider = new StudentDataProvider();
      var students = dataProvider.GetStudents();

      var input = readerWriter.Read();
      if (input?.Equals("p", StringComparison.CurrentCultureIgnoreCase) ?? false)
        students.ToList().ForEach(printerWriter.WriteLine);

      Console.ReadKey();
    }
  }
}
