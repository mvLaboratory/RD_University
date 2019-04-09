using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University_SRP.Core
{
  public class ConsoleReaderWriter
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
