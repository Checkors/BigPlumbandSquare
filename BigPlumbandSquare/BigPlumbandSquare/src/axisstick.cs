using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Server;

namespace BigPlumbandSquare.src
{
    internal class AxisStick : Item
    {
        public override void OnHeldAttackStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, ref EnumHandHandling handling)
        {

            api.Logger.Debug("FACE: {0}, AXIS: {1}", blockSel.Face, blockSel.Face.Axis);

            IPlayer player = (byEntity as EntityPlayer).Player;
            if (player == null)
            {
                api.Logger.Debug("[AXIS_STICK] NO PLAYER");
                return;
            }

            IServerPlayer serverPlayer = (player as IServerPlayer);
            if (serverPlayer == null)
            {
                api.Logger.Debug("[AXIS_STICK] NO SERVER PLAYER");
                return;
            }
            string sd = "This is a string";

            serverPlayer.SendIngameError("AxisStickTest", "FACE: {0}, AXIS: {1}", blockSel.Face.ToString(), blockSel.Face.Axis);
            base.OnHeldAttackStart(slot, byEntity, blockSel, entitySel, ref handling);
        }


    }
}
