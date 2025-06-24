using CommandSystem;
using Exiled.API.Features;
using System;

namespace SCP_1162_Exiled
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(ClientCommandHandler))]
    public class GetRelativePos : ICommand
    {
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player sendPlayer = Player.Get(sender);
            response = $"Относительная позиция в комнате {sendPlayer.CurrentRoom.Type}\n" +
                       $"X: {sendPlayer.CurrentRoom.LocalPosition(sendPlayer.Position).x:F}\n" +
                       $"Y: {sendPlayer.CurrentRoom.LocalPosition(sendPlayer.Position).y:F}\n" +
                       $"Z: {sendPlayer.CurrentRoom.LocalPosition(sendPlayer.Position).z:F}";
            return true;
        }

        public string Command { get; } = "getrpos";
        public string[] Aliases { get; } = Array.Empty<string>();
        public string Description { get; } = "";
    }
}
