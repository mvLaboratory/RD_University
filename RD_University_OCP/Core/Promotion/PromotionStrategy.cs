using System;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP.Core.Promotion
{
  class BasePromotionStrategy : IPromotionStrategy
  {
    public bool CheckPromotion(Student student)
    {
      return true;
    }
  }

  class DeveloperPromotionStrategy : IPromotionStrategy
  {
    public bool CheckPromotion(Student student)
    {
      return student.AverageGrade > 75 
             && student.FinishedCourses.Exists(x => x == Course.Physics)
             && student.FinishedCourses.Exists(x => x == Course.Mathematics)
             && student.FinishedCourses.Exists(x => x == Course.Philosophy)
             && student.BirthDate.AddYears(18) > DateTime.UtcNow;
    }
  }

  class ArtPromotionStrategy : IPromotionStrategy
  {
    public bool CheckPromotion(Student student)
    {
      return student.AverageGrade > 60
             && student.FinishedCourses.Exists(x => x == Course.Philosophy)
             && student.FinishedCourses.Exists(x => x == Course.History)
             && student.BirthDate.AddYears(21) > DateTime.UtcNow;
    }
  }
}