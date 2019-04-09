using System.Linq;
using RD_University_DI.Interfaces;
using RD_University_DI.Models;

namespace RD_University_DI
{
  public class RdUniversity : IRdUniversity
  {
    public RdUniversity(IDateProvider<Student> studentsDataProvider, IReaderWriter consoleReaderWriter, IReaderWriter printerWriter)
    {
      _studentsDataProvider = studentsDataProvider;
      _consoleReaderWriter = consoleReaderWriter;
      _printerWriter = printerWriter;
    }

    public int Execute()
    {
      var students = _studentsDataProvider.GetData();
      var input = _consoleReaderWriter.Read();

      switch (input)
      {
        case "s":
          students.ToList().ForEach(_consoleReaderWriter.Write);
          break;
        case "p":
          students.ToList().ForEach(_printerWriter.Write);
          break;
        case "x":
          return 0;
      }
      return 1;
    }

    private readonly IDateProvider<Student> _studentsDataProvider;
    private readonly IReaderWriter _consoleReaderWriter;
    private readonly IReaderWriter _printerWriter;
  }
}
