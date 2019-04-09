using System;
using RD_University_DI.Interfaces;

namespace RD_University_DI.Core
{
  public class PrinterWriter : IReaderWriter
  {
    public string Read()
    {
      throw new NotSupportedException("It is impossible to read data from printer!");
    }

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
