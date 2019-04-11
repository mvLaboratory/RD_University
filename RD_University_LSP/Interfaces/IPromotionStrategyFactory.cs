using RD_University_LSP.Models;

namespace RD_University_LSP.Interfaces
{
  public interface IPromotionStrategyFactory
  {
    IPromotionStrategy GetStrategy(Specialty specialty);
  }
}
