using System.Collections;
using System.Collections.Generic;
using RD_University_DI.Core;

namespace RD_University.Interfaces
{
  class WriterFactory : IWriterFactory
  {
    public WriterFactory(
      IWriter consoleWriter, 
      IWriter printerWriter)
    {
      _defaultWriter = consoleWriter;
      _writerMap = new Dictionary<string, IWriter>
      {
        {"s", consoleWriter},
        {"p", printerWriter}
      };
    }
    public IWriter GetWriter(string writerType)
    {
      return _writerMap.ContainsKey(writerType)
        ? _writerMap[writerType]
        : _defaultWriter;
    }

    private readonly IWriter _defaultWriter;
    private readonly IDictionary<string, IWriter> _writerMap;
  }
}