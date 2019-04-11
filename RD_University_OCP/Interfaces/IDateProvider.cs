using System.Collections.Generic;

namespace RD_University_OCP.Interfaces
{
  public interface IDateProvider<out T>
  {
    IEnumerable<T> GetData();
  }
}
