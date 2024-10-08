﻿using BigPlumbandSquare.src;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

namespace BigPlumbandSquare
{
    public class BigPlumbandSquareModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            api.Logger.Notification("Hello from template mod: " + api.Side);
            api.RegisterItemClass("AxisStick", typeof(AxisStick));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            api.Logger.Notification("Hello from template mod server side: " + Lang.Get("bigplumbandsquare:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            api.Logger.Notification("Hello from template mod client side: " + Lang.Get("bigplumbandsquare:hello"));
        }
    }
}
