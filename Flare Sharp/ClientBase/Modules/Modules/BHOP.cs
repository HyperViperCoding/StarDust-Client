﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.Memory.FlameSDK;
using System;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class BHOP : Module
    {
        public BHOP() : base("BHOP", CategoryHandler.registry.categories[1], (char)0x07, false)
        {
            RegisterSliderSetting("Speed", -30, 05, 30);
        }

        public override void onTick()
        {
            base.onTick();
            float playerYaw = Minecraft.clientInstance.localPlayer.yaw;

            if (Minecraft.clientInstance.localPlayer.onGround_type2 == 257) Minecraft.clientInstance.localPlayer.velY = 0.3F;

            if (KeybindHandler.isKeyDown('W'))
            {
                if(!KeybindHandler.isKeyDown('A') && !KeybindHandler.isKeyDown('D'))
                {
                    playerYaw += 90F;
                }
                if (KeybindHandler.isKeyDown('A'))
                {
                    playerYaw += 45F;
                } else if (KeybindHandler.isKeyDown('D'))
                {
                    playerYaw += 135F;
                }
            } else if (KeybindHandler.isKeyDown('S'))
            {
                if (!KeybindHandler.isKeyDown('A') && !KeybindHandler.isKeyDown('D'))
                {
                    playerYaw -= 90F;
                }
                if (KeybindHandler.isKeyDown('A'))
                {
                    playerYaw -= 45F;
                }
                else if (KeybindHandler.isKeyDown('D'))
                {
                    playerYaw -= 135F;
                }
            } else if(!KeybindHandler.isKeyDown('W') && !KeybindHandler.isKeyDown('S'))
            {
                if (!KeybindHandler.isKeyDown('A') && KeybindHandler.isKeyDown('D')) playerYaw += 180F;
            }

            if(KeybindHandler.isKeyDown('W') | KeybindHandler.isKeyDown('A') | KeybindHandler.isKeyDown('D') | KeybindHandler.isKeyDown('S'))
            {
                float calcYaw = (playerYaw) * ((float)Math.PI / 180F);
                float calcPitch = (Minecraft.clientInstance.localPlayer.pitch) * -((float)Math.PI / 180F);
                Minecraft.clientInstance.localPlayer.velX = (float)Math.Cos(calcYaw) * sliderSettings[0].value / 10F;
                Minecraft.clientInstance.localPlayer.velZ = (float)Math.Sin(calcYaw) * sliderSettings[0].value / 10F;
            }

        }
    }
}
