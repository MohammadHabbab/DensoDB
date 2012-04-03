﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeNSo.Meta.BSon;

namespace DeNSo.Meta
{
  public interface IStore
  {
    IObjectStore GetStore(string collection);
  }

  public interface IObjectStore
  {
    IEnumerable<BSonDoc> Where(Func<BSonDoc, bool> filter);
    void Set(BSonDoc entity);
    void Remove(BSonDoc entity);
    BSonDoc GetById(int key);
  }
}