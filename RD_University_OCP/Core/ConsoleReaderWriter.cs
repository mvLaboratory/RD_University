using System;
using RD_University_OCP.Interfaces;

namespace RD_University_OCP.Core
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
  }
}
