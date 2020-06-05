using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Twerk2 : Module
    {
        public Twerk2() : base("Twerk2", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
            RegisterSliderSetting("Twerk speed (MS)", 1, 1000, 10000);
        }

        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.vanillaMoveInputHandler.isCrouching = 1;
            System.Threading.Thread.Sleep(320);
            Minecraft.clientInstance.vanillaMoveInputHandler.isCrouching = 0;
        }
    }
}
