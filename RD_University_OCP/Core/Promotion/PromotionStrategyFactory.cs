using System.Collections.Generic;
using RD_University_OCP.Models;

namespace RD_University.Interfaces
{
  public class PromotionStrategyFactory : IPromotionStrategyFactory
  {
    public PromotionStrategyFactory()
    {
      _defaultStrategy = new DeveloperPromotionStrategy();
      _strategyMap = new Dictionary<Specialty, IStrategy>
      {
        {Specialty.Developer, _defaultStrategy},
        {Specialty.Physicist, new PhysicistPromotionStrategy()}
      };
    }


    public IStrategy GetPromotionStrategy(Specialty specialty)
    {
      return _strategyMap.ContainsKey(specialty)
        ? _strategyMap[specialty]
        : _defaultStrategy;
    }

    private readonly IStrategy _defaultStrategy ;
    private readonly Dictionary<Specialty, IStrategy> _strategyMap;
  }
}