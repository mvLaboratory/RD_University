using System.Collections.Generic;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP.Core.Promotion
{
  public class PromotionStrategyFactory: IPromotionStrategyFactory
  {
    public PromotionStrategyFactory()
    {
      _strategiesMap = new Dictionary<Specialty, IPromotionStrategy>
      {
        {Specialty.Art, new ArtPromotionStrategy()},
        {Specialty.Developer, new DeveloperPromotionStrategy()}
      };
    }

    public IPromotionStrategy GetStrategy(Specialty specialty)
    {
      return _strategiesMap.ContainsKey(specialty) ? _strategiesMap[specialty] : _defaultStrategy;
    }

    private readonly IPromotionStrategy _defaultStrategy = new BasePromotionStrategy();
    private readonly Dictionary<Specialty, IPromotionStrategy> _strategiesMap;
  }
}
