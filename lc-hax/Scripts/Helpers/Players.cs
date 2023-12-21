using System.Linq;
using GameNetcodeStuff;

namespace Hax;

public static partial class Helper {
    public static PlayerControllerB? LocalPlayer => GameNetworkManager.Instance.localPlayerController;

    public static PlayerControllerB[]? Players => Helper.StartOfRound?.allPlayerScripts;

    public static PlayerControllerB? GetPlayer(int playerId) => Helper.Players?.FirstOrDefault(player => player.playerClientId == (ulong)playerId);

    public static PlayerControllerB? GetPlayer(string username) => Helper.Players?.FirstOrDefault(player => player.playerUsername == username);

    public static PlayerControllerB? GetActivePlayer(string username) =>
        Helper.GetPlayer(username).IsNotNull(out PlayerControllerB player)
            ? player.isPlayerDead ? null : !player.isPlayerControlled ? null : player
            : null;

    public static PlayerControllerB? GetActivePlayer(int playerId) =>
        Helper.GetPlayer(playerId).IsNotNull(out PlayerControllerB player)
            ? player.isPlayerDead ? null : !player.isPlayerControlled ? null : player
            : null;
}
