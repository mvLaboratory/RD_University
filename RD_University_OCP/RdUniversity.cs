using System;
using System.Linq;
using RD_University_OCP.Core.Promotion;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP
{
  public class RdUniversity : IRdUniversity
  {
    public RdUniversity(IDateProvider<Student> studentsDataProvider, IInputReader consoleReader, IOutputWriterFactory outputWriterFactory)
    {
      _studentsDataProvider = studentsDataProvider;
      _consoleReader = consoleReader;
      _outputWriterFactory = outputWriterFactory;
    }

    public int Execute()
    {
      var students = _studentsDataProvider.GetData();
      var input = _consoleReader.Read();
      
      if (input.Equals("x", StringComparison.InvariantCultureIgnoreCase))
      {
        return 0;
      }
      var writer = _outputWriterFactory.GetWriter(input);

      var promotionAssignator = new PromotionAssignator();
      var studentsForPromotion = promotionAssignator.SelectStudentsForPromotion(students);

      studentsForPromotion.ToList().ForEach(writer.Write);
      return 1;
    }

    private readonly IDateProvider<Student> _studentsDataProvider;
    private readonly IInputReader _consoleReader;
    private readonly IOutputWriterFactory _outputWriterFactory;
  }
}
