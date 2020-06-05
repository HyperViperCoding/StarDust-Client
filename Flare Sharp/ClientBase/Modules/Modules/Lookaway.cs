using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Lookaway : Module
    {
        public Lookaway() : base("Lookaway", CategoryHandler.registry.categories[0], (char)0x07, false)
        {
            RegisterFloatSliderSetting("Range", 0f, 12.0f, 50.0f);
        }


        public override void onTick()
        {
            base.onTick();

            Mob closestEnt = Utils.getClosestEntity(Minecraft.clientInstance.localPlayer.level.getMovingEntities);

            if (closestEnt.username.Length > 0)
            {
                Utils.Vec2f anglesArr = Utils.getCalculationsToPos(Minecraft.clientInstance.localPlayer.location, closestEnt.location);

                Minecraft.clientInstance.firstPersonLookBehavior.cameraPitch = 0 - anglesArr.x;
                Minecraft.clientInstance.firstPersonLookBehavior.cameraYaw = 0 - anglesArr.y;
            }
        }
    }
}
