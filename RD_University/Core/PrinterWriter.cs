using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University.Core
{
    public class PrinterWriter
    {
      public void WriteLine(object objToWrite)
      {
        var driver = new PrinterDriver();
        driver.InitPrinter();
        driver.CheckPaper();
        driver.Print($"bg-bg-bg It is Printer {objToWrite}")

        Console.WriteLine($"bg-bg-bg It is Printer {objToWrite}");

      }
    }


    internal class PrinterDriver
    {
      public bool CheckPaper()
      {
        return true;
      }

      public bool InitPrinter()
      {
        return true;
      }

      public bool StartPrint()
      {
        return true;
      }

      public bool Print(string text)
      {
        return true;
      }
  }
}
