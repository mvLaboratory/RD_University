using System;
using RD_University_OCP.Models;

namespace RD_University.Interfaces
{
  class DeveloperPromotionStrategy : IStrategy
  {
    public bool StudentIsReadyForPromotion(Student studentToCheck)
    {
      //some logic here;
      if (studentToCheck.AverageGrade >= 75
          && studentToCheck.FinishedCourses
            .Exists(course => course == Course.Mathematics))
      {
        return true;
      }

      return false;
    }
  }

  class PhysicistPromotionStrategy : IStrategy
  {
    public bool StudentIsReadyForPromotion(Student studentToCheck)
    {
      //some logic here;
      return true;
    }
  }
}