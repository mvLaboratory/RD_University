using RD_University_LSP.Models;

namespace RD_University_LSP.Interfaces
{
  public interface IPromotionStrategy
  {
    bool CheckPromotion(Student student);
  }
}
