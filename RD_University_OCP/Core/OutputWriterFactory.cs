using System.Collections.Generic;
using RD_University_OCP.Interfaces;

namespace RD_University_OCP.Core
{
  public class OutputWriterFactory : IOutputWriterFactory
  {
    public OutputWriterFactory()
    {
        _writersMap.Add("s", ServiceFactory.GetConsoleWriter());
        _writersMap.Add("p", ServiceFactory.GetPrinterWriter());
    }

    public IOutputWriter GetWriter(string writerType)
    {
      return _writersMap.ContainsKey(writerType) ? _writersMap[writerType] : null;
    }

    private readonly Dictionary<string, IOutputWriter> _writersMap = new Dictionary<string, IOutputWriter>();
  }
}