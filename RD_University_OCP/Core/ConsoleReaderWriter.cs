using System;
using RD_University_ISP.Interfaces;

namespace RD_University_ISP.Core
{
  public class ConsoleReaderWriter : IInputReader, IOutputWriter
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
