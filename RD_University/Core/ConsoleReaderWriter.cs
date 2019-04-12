using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University.Core
{
  public class ConsoleReaderWriter
  {
    public void WriteLine(object objToWrite)
    {
      Console.WriteLine(objToWrite);
    }

    public string Read()
    {
      return Console.ReadLine();
    }
  }
}
