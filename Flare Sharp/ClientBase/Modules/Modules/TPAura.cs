using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class TPAura : Module
    {
        int delayCount = 0;
        int limitCheck = 0;
        public TPAura():base("TPAura", CategoryHandler.registry.categories[1], 0x07, false)
        {
            RegisterSliderSetting("Speed", 0, 10, 500);
            RegisterSliderSetting("Delay", 0, 100, 500);
            RegisterSliderSetting("Limit", 0, 2, 20);
        }
        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.localPlayer.velX = 0;
            Minecraft.clientInstance.localPlayer.velY = 0;
            Minecraft.clientInstance.localPlayer.velZ = 0;
            if (limitCheck <= sliderSettings[2].value || sliderSettings[2].value <= 0)
            {
                if (delayCount >= sliderSettings[1].value)
                {
                    Utils.Vec3f directionalVec = Minecraft.clientInstance.localPlayer.lookingVec;
                    Minecraft.clientInstance.localPlayer.teleport(Minecraft.clientInstance.localPlayer.X1 + sliderSettings[0].value / 10 * directionalVec.x, Minecraft.clientInstance.localPlayer.Y1 + sliderSettings[0].value / 10 * -directionalVec.y, Minecraft.clientInstance.localPlayer.Z1 + sliderSettings[0].value / 10 * directionalVec.z);
                    delayCount = 0;
                    limitCheck++;
                }
                delayCount++;
            }
            else
            {
                this.enabled = false;
                limitCheck = 0;
            }
        }
    public TPAura() : base("TPAura", CategoryHandler.registry.categories[0], (char)0x07, false)
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

                Minecraft.clientInstance.firstPersonLookBehavior.cameraPitch = anglesArr.x;
                Minecraft.clientInstance.firstPersonLookBehavior.cameraYaw = anglesArr.y;
            }
        public static int triggerbotCounter = 0;
        public TPAura() : base("TPAura", CategoryHandler.registry.categories[0], (char)0x07, false)
        {
            RegisterSliderSetting("Delay", 0, 0, 500);
        }

        public override void onTick()
        {
            base.onTick();
            Mob facing = Minecraft.clientInstance.localPlayer.level.lookingEntity;
            if(facing.movedTick > 1)
            {
                MCM.writeBaseByte(Statics.attackSwing, 0);
            } else
            {
                MCM.writeBaseByte(Statics.attackSwing, 1);
            }
        }

        public override void onDisable()
        {
            base.onDisable();
            MCM.writeBaseByte(Statics.attackSwing, 1);
        }}
    }
}
 }
}
