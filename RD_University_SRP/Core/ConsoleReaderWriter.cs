using System;
using System.Collections.Generic;
using System.Text;
using RD_University.Interfaces;

namespace RD_University_SRP.Core
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
  }
}
