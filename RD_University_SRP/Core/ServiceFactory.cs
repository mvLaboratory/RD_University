using System;
using System.Collections.Generic;
using System.Text;
using RD_University.Interfaces;
using RD_University_SRP.Core;
using RD_University_SRP.Data;
using RD_University_SRP.Models;

namespace RD_University.Core
{
  public static class ServiceFactory
  {
    public static IDataProvider<Student> GetStudentDataProvider()
    {
      return new StudentDataProvider();
    }

    public static IReaderWriter GetConsoleReaderWriter()
    {
      return new ConsoleReaderWriter();
    }

    public static IReaderWriter GetPrinterWriter()
    {
      return new PrinterWriter();
    }

    public static IReaderWriter GetChatBotReaderWriter()
    {
      return new ChatBotReaderWriter();
    }

    public static IRdUniversity GetUniversity()
    {
      return new RdUniversity(GetStudentDataProvider(),
        GetChatBotReaderWriter(),
        GetPrinterWriter());
    }
  }
}
