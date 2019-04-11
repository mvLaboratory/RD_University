using System.Collections.Generic;
using RD_University_LSP.Models;

namespace RD_University_LSP.Interfaces
{
  public interface IPromotionAssignator
  {
    IEnumerable<Student> SelectStudentsForPromotion(IEnumerable<Student> students);
  }
}
