﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeNSo.Meta;
using DeNSo.Meta.BSon;

namespace DeNSo.Core.EventHandlers
{
  [HandlesCommand(DensoBuiltinCommands.Set)]
  public class SetHandler : BaseCommandHandler
  {
    public override void OnHandle(IStore store,
                                  string collection,
                                  BSonDoc command,
                                  BSonDoc document)
    {
      IObjectStore st = store.GetCollection(collection);

      if (document.HasProperty(Consts.DensoIDKeyName))
      {
        ReplaceSingleDocument(document, st); return;
      }
      InsertElement(document, st); return;
    }
  }
}