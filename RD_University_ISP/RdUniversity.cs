using System.Linq;
using RD_University_ISP.Interfaces;
using RD_University_ISP.Models;

namespace RD_University_ISP
{
  public class RdUniversity : IRdUniversity
  {
    public RdUniversity(IDateProvider<Student> studentsDataProvider, IInputReader consoleReaderWriter, IOutputWriter printerWriter)
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
    private readonly IInputReader _consoleReaderWriter;
    private readonly IOutputWriter _printerWriter;
  }
}
