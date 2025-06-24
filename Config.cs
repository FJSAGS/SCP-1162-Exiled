using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace SCP_1162_Exiled
{
    public class Config : IConfig
    {
        [Description("If the plugin should be enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("If debug messages should be shown")]
        public bool Debug { get; set; } = false;

        [Description("Hint popup that will be shown to player")]
        public string HintOnUse { get; set; } =
            "<color=yellow><i>Вы обменяли предмет в <color=red>SCP-1162</color></color></i>";

        [Description("Hint popup when plugin did not accept an item")]
        public string HintOnReject { get; set; } =
            "<color=yellow>Вы ничего не нашли.</color>";

        [Description("Items that will be considered common by plugin")]
        public List<ItemType> CommonItems { get; set; } = new()
        {
            ItemType.Coin,
            ItemType.KeycardJanitor,
            ItemType.Radio,
            ItemType.Lantern,
            ItemType.Medkit,
            ItemType.Painkillers,
            ItemType.Flashlight,
            ItemType.GrenadeFlash
        };
        [Description("Items that will be considered uncommon by plugin")]
        public List<ItemType> UncommonItems { get; set; } = new()
        {
            ItemType.KeycardScientist,
            ItemType.KeycardResearchCoordinator,
            ItemType.KeycardZoneManager,
            ItemType.Adrenaline,
            ItemType.ArmorLight,
            ItemType.GunCOM15,
            ItemType.GunCOM18,
            ItemType.SCP207,
            ItemType.SCP1853,
            ItemType.SCP2176
        };
        [Description("Items that will be considered good by plugin")]
        public List<ItemType> GoodItems { get; set; } = new()
        {
            ItemType.KeycardGuard,
            ItemType.SurfaceAccessPass,
            ItemType.KeycardContainmentEngineer,
            ItemType.SCP500,
            ItemType.ArmorCombat,
            ItemType.GunFSP9,
            ItemType.GunCrossvec,
            ItemType.GrenadeHE
        };
        [Description("Items that will be considered rare by plugin")]
        public List<ItemType> RareItems { get; set; } = new()
        {
            ItemType.KeycardMTFPrivate,
            ItemType.KeycardMTFOperative,
            ItemType.ArmorHeavy,
            ItemType.GunRevolver,
            ItemType.GunShotgun,
            ItemType.GunCom45,
            ItemType.GunA7,
            ItemType.GunAK,
            ItemType.GunE11SR,
            ItemType.GunSCP127,
            ItemType.AntiSCP207,
            ItemType.SCP1576,
            ItemType.SCP018
        };
        [Description("Items that will be considered very rare by plugin")]
        public List<ItemType> VeryRareItems { get; set; } = new()
        {
            ItemType.KeycardFacilityManager,
            ItemType.KeycardO5,
            ItemType.KeycardMTFCaptain,
            ItemType.KeycardChaosInsurgency,
            ItemType.ParticleDisruptor,
            ItemType.MicroHID,
            ItemType.Jailbird,
            ItemType.GunFRMG0,
            ItemType.GunLogicer,
            ItemType.SCP268,
            ItemType.SCP1344,
        };
    }
}