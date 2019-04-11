using RD_University_OCP.Data;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP.Core
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
