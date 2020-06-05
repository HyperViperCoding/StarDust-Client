using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;
using System;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class YesFall : Module
    {
        public YesFall() : base("YesFall", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
        }
        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.localPlayer.isFalling = 1;
        }
    }
}
