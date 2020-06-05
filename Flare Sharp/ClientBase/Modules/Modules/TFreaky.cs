using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class TFreaky : Module
    {
        public TFreaky() : base("TFreaky", CategoryHandler.registry.categories[0], (char)0x07, false)
        {
        }
    }
}