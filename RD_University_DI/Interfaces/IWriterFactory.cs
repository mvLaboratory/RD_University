using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University.Interfaces
{
  public interface IWriterFactory
  {
    IWriter GetWriter(string writerType);
  }
}
