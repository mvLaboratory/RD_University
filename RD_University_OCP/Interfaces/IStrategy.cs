using System.Collections.Generic;
using System.Text;
using RD_University_OCP.Models;

namespace RD_University.Interfaces
{
  public interface IStrategy
  {
    bool StudentIsReadyForPromotion(Student studentToCheck);
  }
}
