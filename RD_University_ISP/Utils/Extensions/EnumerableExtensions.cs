using System.Collections;
using RD_University_ISP.Interfaces;

namespace RD_University_ISP.Utils.Extensions
{
  public static class EnumerableExtensions
  {
    public static void Process(this IEnumerable collection, IOutputWriter dataProcessor)
    {
      foreach (var element in collection)
      {
        dataProcessor.Process(element);
      }
    }
  }
}
