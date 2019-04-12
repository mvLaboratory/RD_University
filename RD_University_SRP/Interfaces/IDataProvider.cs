using System;
using System.Collections.Generic;
using System.Text;
using RD_University_SRP.Models;

namespace RD_University.Interfaces
{
    public interface IDataProvider<out T>
    {
      IEnumerable<T> GetData();
    }
}
