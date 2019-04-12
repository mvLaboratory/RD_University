using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University.Interfaces
{
  public interface IReaderWriter
  {
    string Read();

    void Write(object objectToWrite);
  }
}
