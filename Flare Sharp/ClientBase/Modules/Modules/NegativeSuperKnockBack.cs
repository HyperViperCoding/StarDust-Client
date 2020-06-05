using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class NegativeSuperKnockBack : Module
    {
        public NegativeSuperKnockBack() : base("NegativeSuperKnockBack", CategoryHandler.registry.categories[1], (char)0x07, false)
        {
        }

        public override void onEnable()
        {
            base.onEnable();
            MCM.writeBaseByte(Statics.NegativeSuperKnockBackX, -16);
            MCM.writeBaseByte(Statics.NegativeSuperKnockBackY, -16);
            MCM.writeBaseByte(Statics.NegativeSuperKnockBackZ, -16);
        }

        public override void onDisable()
        {
            base.onDisable();
            MCM.writeBaseByte(Statics.NegativeSuperKnockBackX, 4);
            MCM.writeBaseByte(Statics.NegativeSuperKnockBackY, 4);
            MCM.writeBaseByte(Statics.NegativeSuperKnockBackZ, 4);
        }
    }
}
