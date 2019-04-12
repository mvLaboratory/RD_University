using System;
using System.Collections.Generic;
using System.Text;
using RD_University_OCP.Models;

namespace RD_University.Interfaces
{
    public interface IPromotionStrategyFactory
    {
      IStrategy GetPromotionStrategy(Specialty specialty);
    }
}
