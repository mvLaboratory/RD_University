using System;
using RD_University_LSP.Interfaces;

namespace RD_University_LSP.Core
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
