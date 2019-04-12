using RD_University.Interfaces;
using RD_University_DI.Data;
using RD_University_DI.Interfaces;
using RD_University_DI.Models;

namespace RD_University_DI.Core
{
  public class ServiceFactory
  {
    public static IRdUniversity CreateRdUniversity()
    {
      return new RdUniversity(GetDataStudentProvider(), GetConsoleReader(), GetWriterFactory());
    }

    public static IDateProvider<Student> GetDataStudentProvider()
    {
      return new StudentDataProvider();
    }

    public static IReader GetConsoleReader()
    {
      return new ConsoleReaderWriter();
    }

    public static IWriter GetConsoleWriter()
    {
      return new ConsoleReaderWriter();
    }

    public static IWriter GetPrinterWriter()
    {
      return new PrinterWriter();
    }

    public static IWriterFactory GetWriterFactory()
    {
      return new WriterFactory(GetConsoleWriter(), GetPrinterWriter());
    }
  }
}
