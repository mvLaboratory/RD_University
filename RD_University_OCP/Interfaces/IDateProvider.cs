using System.Collections.Generic;

namespace RD_University_ISP.Interfaces
{
  public interface IDateProvider<out T>
  {
    IEnumerable<T> GetData();
  }
}
