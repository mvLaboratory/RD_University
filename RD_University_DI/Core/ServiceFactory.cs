using RD_University_DI.Data;
using RD_University_DI.Interfaces;
using RD_University_DI.Models;

namespace RD_University_DI.Core
{
  public class ServiceFactory
  {
    public static IRdUniversity CreateRdUniversity()
    {
      return new RdUniversity(GetDataStudentProvider(), GetConsoleReaderWriter(), GetPrinterWriter());
    }

    public static IDateProvider<Student> GetDataStudentProvider()
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
  }
}
