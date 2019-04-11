using System.Collections.Generic;
using RD_University_OCP.Models;

namespace RD_University_OCP.Interfaces
{
  public interface IPromotionAssignator
  {
    IEnumerable<Student> SelectStudentsForPromotion(IEnumerable<Student> students);
  }
}
