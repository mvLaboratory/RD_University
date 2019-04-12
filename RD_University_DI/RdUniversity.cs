using System;
using System.Linq;
using RD_University.Interfaces;
using RD_University_DI.Interfaces;
using RD_University_DI.Models;

namespace RD_University_DI
{
  public class RdUniversity : IRdUniversity
  {
    public RdUniversity(
      IDateProvider<Student> studentsDataProvider,
      IReader consoleReader, 
      IWriterFactory writerFactory)
    {
      _studentsDataProvider = studentsDataProvider;
      _consoleReader = consoleReader;
      _writerFactory = writerFactory;
    }

    public int Execute()
    {
      var students = _studentsDataProvider.GetData();
      var input = _consoleReader.Read();

      if (input.Equals("x", StringComparison.CurrentCultureIgnoreCase))
      {
        return 0;
      }
      //switch (input)
      //{
      //  case "s":
      //    students.ToList().ForEach(_consoleWriter.Write);
      //    break;
      //  case "p":
      //    students.ToList().ForEach(_printerWriter.Write);
      //    break;
      //  case "x":
      //    return 0;
      //}

      var writer = _writerFactory.GetWriter(input);
      students.ToList().ForEach(writer.Write);
      return 1;
    }

    private readonly IDateProvider<Student> _studentsDataProvider;
    private readonly IReader _consoleReader;
    private readonly IWriterFactory _writerFactory;
  }
}
