using System;
using RD_University_DI.Interfaces;

namespace RD_University_DI.Core
{
  public class ConsoleReaderWriter : IReaderWriter
  {
    public string Read()
    {
      return Console.ReadLine();
    }

    public void Write(object objectToWrite)
    {
      Console.WriteLine(objectToWrite);
    }

    public void Process(object objectToProcess)
    {
      Write(objectToProcess);
    }
  }
}
