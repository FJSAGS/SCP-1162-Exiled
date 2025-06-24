using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using UnityEngine;
using Random = UnityEngine.Random;

namespace SCP_1162_Exiled
{
    public class EventHandlers
    {
        public static readonly Vector3 Point1 = new(11.5f, 17.5f, 3.4f);
        public static readonly Vector3 Point2 = new(22.3f, 10.7f, 12.5f);
        public static void DroppedItem(DroppedItemEventArgs args)
        {
            if (args.Player.CurrentRoom.Type != RoomType.Lcz173) return;
            Vector3 playerRelativePosition = args.Player.CurrentRoom.LocalPosition(args.Player.Position);
            bool playerXCoordinateInsideBox =
                (Point1.x <= playerRelativePosition.x && playerRelativePosition.x <= Point2.x);
            bool playerYCoordinateInsideBox =
                (Point1.y >= playerRelativePosition.y && playerRelativePosition.y >= Point2.y);
            bool playerZCoordinateInsideBox =
                (Point1.z <= playerRelativePosition.z && playerRelativePosition.z <= Point2.z);
            bool playerInsideBox =
                playerZCoordinateInsideBox && playerXCoordinateInsideBox && playerYCoordinateInsideBox;
            if (!playerInsideBox) return;


            int randNum = Random.Range(1, 101);
            int rarityNum = 0;
            if (Scp1162.Instance.Config.CommonItems.Contains(args.Pickup.Type)) rarityNum = 10;
            else if (Scp1162.Instance.Config.UncommonItems.Contains(args.Pickup.Type)) rarityNum = 55;
            else if (Scp1162.Instance.Config.GoodItems.Contains(args.Pickup.Type)) rarityNum = 70;
            else if (Scp1162.Instance.Config.RareItems.Contains(args.Pickup.Type)) rarityNum = 87;
            else if (Scp1162.Instance.Config.VeryRareItems.Contains(args.Pickup.Type)) rarityNum = 100;
            else
            {
                args.Player.ShowHint(Scp1162.Instance.Config.HintOnReject);
                return;
            }

            Item item;
            double decider = (rarityNum * 1.25 + randNum * 1) / 2.25;
            if (randNum <= 10)
            {
                item = Item.Create(Scp1162.AmmoTypes.RandomItem());
            }
            else
            {
                switch (decider)
                {
                    case <= 40:
                        item = Item.Create(Scp1162.Instance.Config.CommonItems.RandomItem());
                        break;
                    case <= 55:
                        item = Item.Create(Scp1162.Instance.Config.UncommonItems.RandomItem());
                        break;
                    case <= 70:
                        item = Item.Create(Scp1162.Instance.Config.GoodItems.RandomItem());
                        break;
                    case <= 87:
                        item = Item.Create(Scp1162.Instance.Config.RareItems.RandomItem());
                        break;
                    default:
                        item = Item.Create(Scp1162.Instance.Config.VeryRareItems.RandomItem());
                        break;
                }
            }
            if (Scp1162.Instance.Config.Debug)
            {
                Log.Info($"Rolled {args.Pickup.Type}. RarityNum: {rarityNum}; RandNum: {randNum}.\n" +
                          $"Number: {decider}.\n" +
                          $"Item: {item.Type}");
            }
            args.Pickup.Destroy();
            if (item.IsFirearm)
            {
                Firearm firearm = (Firearm)item;
                firearm.MagazineAmmo = firearm.MaxMagazineAmmo;
                firearm.CreatePickup(args.Player.Position);
            }
            else item.CreatePickup(args.Player.Position);


            args.Player.ShowHint(Scp1162.Instance.Config.HintOnUse);
        }

    }
}