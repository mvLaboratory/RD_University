using System.Collections.Generic;
using System.Linq;
using RD_University.Interfaces;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP.Core.Promotion
{
  public class PromotionAssignator : IPromotionAssignator
  {
    public PromotionAssignator()
    {
      _promotionStrategyFactory = new PromotionStrategyFactory();
    }

    public IEnumerable<Student> SelectStudentsForPromotion(IEnumerable<Student> students)
    {
      var result = new List<StudentForPromotion>();
      foreach (var student in students)
      {
        if (_promotionStrategyFactory.GetPromotionStrategy(student.Specialty).StudentIsReadyForPromotion(student))
        {
          var stud = new StudentForPromotion(student.Id);
          stud.IsReady = true;
          
          result.Add(stud);
        }
      }

      return result;
    }

    public IEnumerable<Student> SelectDeveloperStudentsForPromotion(IEnumerable<Student> students)
    {
      var result = new List<StudentForPromotion>();
      foreach (var student in students)
      {
        if (_promotionStrategyFactory.GetPromotionStrategy(student.Specialty).StudentIsReadyForPromotion(student))
        {
          var stud = new StudentForPromotion(student.Id);
          stud.IsReady = true;

          result.Add(stud);
        }
      }

      return result;
    }

    private readonly PromotionStrategyFactory _promotionStrategyFactory = new PromotionStrategyFactory();
  }
}
