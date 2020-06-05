using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Twerk3 : Module
    {
        public Twerk3() : base("Twerk3", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
            RegisterSliderSetting("Twerk speed (MS)", 1, 1000, 10000);
        }

        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.vanillaMoveInputHandler.isCrouching = 1;
            Minecraft.clientInstance.vanillaMoveInputHandler.isCrouching = 0;
        }
    }
}
