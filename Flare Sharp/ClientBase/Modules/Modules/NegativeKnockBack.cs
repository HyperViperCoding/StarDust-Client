using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class NegativeKnockBack : Module
    {
        public NegativeKnockBack() : base("NegativeKnockBack", CategoryHandler.registry.categories[1], (char)0x07, false)
        {
        }

        public override void onEnable()
        {
            base.onEnable();
            MCM.writeBaseByte(Statics.NegativeKnockBackX, -4);
            MCM.writeBaseByte(Statics.NegativeKnockBackY, -4);
            MCM.writeBaseByte(Statics.NegativeKnockBackZ, -4);
        }

        public override void onDisable()
        {
            base.onDisable();
            MCM.writeBaseByte(Statics.NegativeKnockBackX, 4);
            MCM.writeBaseByte(Statics.NegativeKnockBackY, 4);
            MCM.writeBaseByte(Statics.NegativeKnockBackZ, 4);
        }
    }
}
