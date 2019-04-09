using System.Collections.Generic;

namespace RD_University_DI.Interfaces
{
  public interface IDateProvider<out T>
  {
    IEnumerable<T> GetData();
  }
}
