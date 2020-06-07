using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class SuperKnockBack : Module
    {
        public SuperKnockBack() : base("SuperKnockBack", CategoryHandler.registry.categories[1], (char)0x07, false)
        {
        }

        public override void onEnable()
        {
            base.onEnable();
            MCM.writeBaseByte(Statics.SuperKnockBackX, 16);
            MCM.writeBaseByte(Statics.SuperKnockBackY, 16);
            MCM.writeBaseByte(Statics.SuperKnockBackZ, 16);
        }

        public override void onDisable()
        {
            base.onDisable();
            MCM.writeBaseByte(Statics.SuperKnockBackX, 4);
            MCM.writeBaseByte(Statics.SuperKnockBackY, 4);
            MCM.writeBaseByte(Statics.SuperKnockBackZ, 4);
        }
    }
}
