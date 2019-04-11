using System.Collections.Generic;
using System.Linq;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP.Core.Promotion
{
  public class PromotionAssignator : IPromotionAssignator
  {
    public PromotionAssignator(IPromotionStrategyFactory factory)
    {
      _factory = factory;
    }

    public IEnumerable<Student> SelectStudentsForPromotion(IEnumerable<Student> students)
    {
      return students.Where(CheckPromotion);
    }

    private bool CheckPromotion(Student student)
    {
      return _factory.GetStrategy(student.Specialty).CheckPromotion(student);
    }

    private readonly IPromotionStrategyFactory _factory;

    //public IEnumerable<Student> SelectStudentsForPromotion(IEnumerable<Student> students)
    //{
    //  var result = new List<Student>();
    //  foreach (var student in students)
    //  {
    //    if (student.Specialty != Specialty.Physicist)
    //    {
    //      continue;
    //    }

    //    if (student.Specialty == Specialty.Developer && student.AverageGrade >= 75)
    //    {
    //      foreach (var course in student.FinishedCourses)
    //      {
    //        //Some Logic here
    //      }
    //      result.Add(student);
    //    }
    //  }

    //  return result;
    //}
  }
}
