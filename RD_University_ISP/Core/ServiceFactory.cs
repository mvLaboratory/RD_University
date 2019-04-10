using RD_University_ISP.Data;
using RD_University_ISP.Interfaces;
using RD_University_ISP.Models;

namespace RD_University_ISP.Core
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

    public static IInputReader GetConsoleReader()
    {
      return new ConsoleReaderWriter();
    }

    public static IOutputWriter GetConsoleWriter()
    {
      return new ConsoleReaderWriter();
    }

    public static IOutputWriter GetPrinterWriter()
    {
      return new PrinterWriter();
    }

    public static IOutputWriterFactory GetWriterFactory()
    {
      return new OutputWriterFactory();
    }
  }
}
