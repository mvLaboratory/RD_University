using RD_University_OCP.Models;

namespace RD_University_OCP.Interfaces
{
  public interface IPromotionStrategy
  {
    bool CheckPromotion(Student student);
  }
}
