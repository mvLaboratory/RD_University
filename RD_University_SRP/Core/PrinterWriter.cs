using System;
using RD_University.Interfaces;

namespace RD_University_SRP.Core
{
  public class PrinterWriter : IReaderWriter
  {
    public string Read()
    {
      throw new NotSupportedException();
    }

    public void Write(object objectToWrite)
    {
      Console.WriteLine($"Bg-bg-bg Printer is printing => {objectToWrite} ");
    }
  }
}
