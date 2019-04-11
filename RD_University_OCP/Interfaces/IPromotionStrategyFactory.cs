using RD_University_OCP.Models;

namespace RD_University_OCP.Interfaces
{
  public interface IPromotionStrategyFactory
  {
    IPromotionStrategy GetStrategy(Specialty specialty);
  }
}
