﻿using System.Collections.Generic;

namespace RD_University_LSP.Interfaces
{
  public interface IDateProvider<out T>
  {
    IEnumerable<T> GetData();
  }
}
