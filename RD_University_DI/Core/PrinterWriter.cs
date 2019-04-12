using System;
using RD_University.Interfaces;
using RD_University_DI.Interfaces;

namespace RD_University_DI.Core
{
  public class PrinterWriter : IWriter
  {
    public void Write(object objectToWrite)
    {
      Console.WriteLine($"Bg-bg-bg Printer is printing => {objectToWrite} ");
    }

    public void Process(object objectToProcess)
    {
      Write(objectToProcess);
    }
  }
}
