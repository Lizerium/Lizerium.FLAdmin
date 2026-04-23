/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace FlAdmin.Common.Models;

public static class FlHookApiRoutes
{
    public const string Ping = "/ping";
    public const string CharacterIsOnline = "/getonlinecharacter";
    public const string KickCharacter = "/kickcharacter";
    public const string KillCharacter = "/killcharacter";
    public const string MessagePlayer = "/messageplayer";
    public const string MessageSystem = "/messagesystem";
    public const string MessageUniverse = "/messageuniverse";
    public const string BeamPlayer = "/beamplayer";
    public const string TeleportPlayer = "/teleportplayer";
    public const string GetOnlinePlayers = "/onlineplayers";
}