using Exiled.API.Features;
using System;
using System.Collections.Generic;

namespace SCP_1162_Exiled
{
    public class Scp1162 : Plugin<Config>
    {
        public override string Author => "FJSAGS";
        public override Version RequiredExiledVersion => new(9, 6, 1);
        public override string Name => "SCP-1162";
        public override Version Version => new(0, 0, 0);
        public static Scp1162 Instance;
        public static List<ItemType> AmmoTypes { get; set; } = new()
        {
            ItemType.Ammo12gauge,
            ItemType.Ammo44cal,
            ItemType.Ammo556x45,
            ItemType.Ammo762x39,
            ItemType.Ammo9x19
        };
        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.DroppedItem += EventHandlers.DroppedItem;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            Exiled.Events.Handlers.Player.DroppedItem -= EventHandlers.DroppedItem;
            base.OnDisabled();
        }
    }
}
